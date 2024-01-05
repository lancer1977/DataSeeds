using Pathfinder.DocConverter.Exporters;
using PFAExcelToXML;

namespace Pathfinder.DocConverter.Generators
{
    public class SkillXml : IGeneratorModel
    {
     
        public   string Name => @"Skill";
        public   string Worksheet => @"Skills";
        public   string OutputName => @"skilldb.xml";
        public   string Header => @"
  <xs:schema id = ""NewDataSet"" xmlns="""" xmlns:xs=""http://www.w3.org/2001/XMLSchema"" xmlns:msdata=""urn:schemas-microsoft-com:xml-msdata"">
    <xs:element name = ""NewDataSet"" msdata:IsDataSet=""true"" msdata:UseCurrentLocale=""true"">
      <xs:complexType>
        <xs:choice minOccurs = ""0"" maxOccurs=""unbounded"">
          <xs:element name = ""Skill"" >
            <xs:complexType>
 <xs:attribute name = ""Id"" type=""xs:int""  use=""required""/>
              <xs:attribute name = ""Name"" type=""xs:string"" use=""required"" />
              <xs:attribute name = ""Stat"" type=""xs:string"" use=""required"" />
              <xs:attribute name = ""Description"" type=""xs:string""/>
              <xs:attribute name = ""Game"" type=""xs:string"" use=""required"" />
              <xs:attribute name = ""Trained"" type=""xs:boolean"" use=""required"" />
              <xs:attribute name = ""CategoryId"" type=""xs:int"" use=""required"" /> 
            </xs:complexType>
          </xs:element>
        </xs:choice>
      </xs:complexType>
    </xs:element>
  </xs:schema>
";
    }
}