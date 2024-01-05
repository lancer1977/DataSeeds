using PFAExcelToXML;

namespace Pathfinder.DocConverter.Exporters
{
    public class Generator : IGenerator
    {
        public Generator(string fileSource, GeneratorType gtype)
        {
            _fileSource = fileSource;
            _gtype = gtype;
        }

        public string Extension =>  _gtype == GeneratorType.JSON ? ".js" : ".xml";

        private string _fileSource { get; }
        private GeneratorType _gtype { get; }

        public string GenerateData(IGeneratorModel model)
        {
            var sheet = new Worksheet(model, _fileSource);
            return _gtype == GeneratorType.JSON ? sheet.GetJson() : sheet.GetXml(); 
        }

        public string GenerateEnum(IGeneratorModel model)
        {
            var sheet = new Worksheet(model, _fileSource);
            return sheet.GenerateEnums(); 
        }
    }
}