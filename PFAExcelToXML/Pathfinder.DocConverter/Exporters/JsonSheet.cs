using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using LinqToExcel;
using Newtonsoft.Json;

namespace PFAExcelToXML.Exporters
{
    public class JsonSheet
    {
        private readonly string _name;
        private readonly string _worksheet;
        private readonly ExcelQueryFactory _factory; 
        private readonly List<string> _headers = new List<string>();
        private readonly string _header;
       //private bool NeedsId;

        public JsonSheet(string name, string worksheet,string header,string source)
        {
            _name = name;
            _worksheet = worksheet;
            _factory = new ExcelQueryFactory(source);  
            _header = header;
            PopulateHeaders();
        }

        public string GetJson()
        { 
            //NeedsId = !(_headers.Contains("Id")  );
            var rows = GetRows();
            var json = "{";
            json += _header;
            json = rows.Aggregate(json, (current, item) => current + (item + "," + Environment.NewLine ));
            json += "}";
            return json;
        }

        private void PopulateHeaders()
        {
            var withHead = _factory.Worksheet(_worksheet);
            var nohead = _factory.WorksheetNoHeader(_worksheet);
            var toprow = nohead.First();
            _headers.AddRange(toprow.Select(i => i.Cast<string>())); 
        }

        private List<string> GetRows()
        {
            var items = new List<string>();
            var headed = _factory.Worksheet(_worksheet).ToArray();
            for (var y = 1; y <= headed.Count();y++)
            {
                var item = headed[y-1];
                var hold = $"<{_name} ";
                if (NeedsId) hold += "{" +  $"Id:{y}";
                for (var x = 0; x < _headers.Count; x++)
                {
                    var localHeader = _headers[x];
                    var localItem = item[x].Cast<string>();
                    if (string.IsNullOrEmpty(localItem )) continue;

                    hold += localHeader + $":\"{JsonConvert.ToString(localItem)},";

                }
                hold += " }";
                items.Add(hold);
            } 
            Debug.WriteLine(items.Count);
            return items;
        }

        private List<string> GetEnums()
        {
            var items = new List<string>();
            var rows = _factory.Worksheet(_worksheet).ToArray();
            var indexOfName = _headers.IndexOf("Name");
            for (var rowIndex = 1; rowIndex <= rows.Count(); rowIndex++)
            {
                var row = rows[rowIndex - 1];
   
                    var localItem = row[indexOfName].Cast<string>(); 
                
                items.Add(localItem);
            }
            Debug.WriteLine(items.Count);
            return items;
        }

 
    }
}