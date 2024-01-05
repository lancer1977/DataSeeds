using Pathfinder.DocConverter.Exporters;
using PFAExcelToXML;

namespace Pathfinder.DocConverter.Generators
{
    public class GenericModel : IGeneratorModel
    {
        public string Name { get; set; }
        public string Worksheet { get; set; }
        public string OutputName { get; set; }

        public string Header
        {
            get; set;
        }
    }
     
}