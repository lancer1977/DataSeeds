using Pathfinder.DocConverter.Exporters;
using PFAExcelToXML;

namespace Pathfinder.DocConverter.Generators
{
    public class FeatXml : IGeneratorModel
    {

        public   string Name => @"Feat";
        public   string Worksheet => @"Feats";
        public   string OutputName => @"featdb.xml";
        public   string Header => @"
    <xs:schema id=""root"" xmlns="""" xmlns:xs=""http://www.w3.org/2001/XMLSchema""
             xmlns:msdata=""urn:schemas-microsoft-com:xml-msdata"">
    <xs:element name = ""root"" msdata:IsDataSet=""true"" msdata:UseCurrentLocale=""true"">
      <xs:complexType>
        <xs:choice minOccurs = ""0"" maxOccurs=""unbounded"">
          <xs:element name = ""Feat"" maxOccurs=""79228162514264337593543950335"">
            <xs:complexType>
 <xs:attribute name = ""Id"" type=""xs:int""  use=""required""/>
              <xs:attribute name = ""Name"" type=""xs:string"" use=""required"" />
              <xs:attribute name = ""Type"" type=""xs:string"" use=""required"" />
              <xs:attribute name = ""Implemented"" type=""xs:boolean"" />
              <xs:attribute name = ""Multiples"" type=""xs:boolean"" />
              <xs:attribute name = ""Options"" type=""xs:string"" />
              <xs:attribute name = ""Benefit"" type=""xs:string"" />
              <xs:attribute name = ""Prereq"" type=""xs:string"" />
              <xs:attribute name = ""PrereqFeat"" type=""xs:string"" />
              <xs:attribute name = ""Description"" type=""xs:string"" />
              <xs:attribute name = ""Source"" type=""xs:string"" />
              <xs:attribute name = ""System"" type=""xs:string"" />
            </xs:complexType>
          </xs:element>
        </xs:choice>
      </xs:complexType>
    </xs:element>
  </xs:schema>
";
    }
}