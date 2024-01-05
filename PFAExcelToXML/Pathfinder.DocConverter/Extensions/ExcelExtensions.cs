using System.Collections.Generic;
using System.Linq;
using LinqToExcel;

namespace Pathfinder.DocConverter.Extensions
{
    public static class ExcelExtensions
    {
        public static IList<string> GetHeaders(this ExcelQueryFactory _factory,string worksheet )
        { 
        var withHead = _factory.Worksheet(worksheet);
            var nohead = _factory.WorksheetNoHeader(worksheet);
            var toprow = nohead.First();
            return toprow.Select(i => i.Cast<string>()).ToList();
        }

    }

}