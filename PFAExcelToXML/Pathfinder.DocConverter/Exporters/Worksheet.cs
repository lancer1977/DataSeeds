using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using LinqToExcel;
using Newtonsoft.Json;
using Pathfinder.DocConverter.Extensions;
using PolyhydraGames.Extensions;

namespace Pathfinder.DocConverter.Exporters
{
    public class Worksheet
    {
        private readonly string _name;
        private readonly string _worksheet;
        private readonly ExcelQueryFactory _factory;
        private readonly IList<string> _headers;
        private readonly string _header;

        public static List<string> GetWorksheetNames(string fileSource){
            try
            {
                var factory = new ExcelQueryFactory(fileSource);
                return factory.GetWorksheetNames().ToList(); 
            }
            catch (Exception ex)
            {
                throw new Exception(
                    @"https://www.microsoft.com/en-us/download/details.aspx?id=13255 for 2010 Dist file" +
                    ex.Message);
            }
  
        }

        public Worksheet(IGeneratorModel generator,string fileSource) // string name, string worksheet, string header, string source)
        {
            _name = generator.Name;
            _worksheet = generator.Worksheet;
            _factory = new ExcelQueryFactory(fileSource);
            _header = generator.Header;
            _headers = _factory.GetHeaders(_worksheet); 
        }

        private List<string> GetJsonRows()
        {
            var items = new List<string>();
            var headed = _factory.Worksheet(_worksheet).ToArray();
            var jsonHeaders = _headers.Select(JsonConvert.ToString).ToList();
            for (var y = 1; y <= headed.Count(); y++)
            {
                var item = headed[y - 1];
                var hold = "{";
                var innerItems = new List<string>();
                for (var x = 0; x < _headers.Count; x++)
                {
                    var localHeader = jsonHeaders[x];
                    var localItem = item[x].Cast<string>();
                    if (string.IsNullOrEmpty(localItem)) continue;
                    if(localItem.IsNumeric(out var number))
                    {
                        innerItems.Add(localHeader + $":{number}");
                    }
                    else
                    {
                        innerItems.Add(localHeader + $":{JsonConvert.ToString(localItem)}");
                    }
            

                }
                hold += innerItems.Aggregate( (prev, cur) => prev + ", " + cur);
                hold += " }";
                items.Add(hold);
            }
            Debug.WriteLine(items.Count);
            return items;
        }


        public string GetJson()
        {
            //NeedsId = !(_headers.Contains("Id")  );
            var rows = GetJsonRows();
            var json = "["; 
            json += rows.Aggregate( (current, item) => current + "," + Environment.NewLine + item );
            json += "]";
            return json;
        }

        public string GetXml()
        { 
            var rows = GetXMLRows();
            var xml = @"<?xml version=""1.0"" standalone=""yes""?>
                <root> ";
            xml += _header;
            xml = rows.Aggregate(xml, (current, item) => current + (item + Environment.NewLine));
            xml += "</root>";
            return xml;
        }


        private List<string> GetXMLRows()
        {
            var items = new List<string>();
            var headed = _factory.Worksheet(_worksheet).ToArray();
            for (var y = 1; y <= headed.Count(); y++)
            {
                var item = headed[y - 1];
                var hold = $"<{_name} ";
                //if (NeedsId) hold += $"Id=\"{y}\" ";
                for (var x = 0; x < _headers.Count; x++)
                {
                    var localHeader = _headers[x];
                    var localItem = item[x].Cast<string>();
                    if (string.IsNullOrEmpty(localItem)) continue;

                    hold += $"{localHeader}=\"{localItem.Replace("\"", "&quot;").Replace("&", "&amp;")}\" ";

                }
                hold += " />";
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

        public string GenerateEnums()
        {

            var rows = GetEnums();
            var xml = "public enum " + _name + "{" + Environment.NewLine;
            xml = xml + rows.Aggregate((current, item) => current + (item + "," + Environment.NewLine));
            xml += "}";
            return xml;
        }
    }
}