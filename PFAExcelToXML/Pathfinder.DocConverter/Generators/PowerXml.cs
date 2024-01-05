using Pathfinder.DocConverter.Exporters;
using PFAExcelToXML;

namespace Pathfinder.DocConverter.Generators
{
    public class PowerXml : IGeneratorModel
    {

        public   string Name => @"Power";
        public   string Worksheet => @"Powers";
        public   string OutputName => @"powersdb.xml";
        public   string Header => @"
  <xs:schema id=""root"" xmlns="""" xmlns:xs=""http://www.w3.org/2001/XMLSchema""
             xmlns:msdata=""urn:schemas-microsoft-com:xml-msdata"">
    <xs:element name = ""root"" msdata:IsDataSet=""true"" msdata:UseCurrentLocale=""true"">
      <xs:complexType>
        <xs:choice minOccurs = ""0"" maxOccurs=""unbounded"">
          <xs:element name = ""Power"" maxOccurs=""79228162514264337593543950335"">
            <xs:complexType>
               <xs:attribute name = ""Id"" type=""xs:int""  use=""required""/>
              <xs:attribute name = ""Name"" type=""xs:string"" use=""required"" />
              <xs:attribute name = ""Type"" type=""xs:string"" use=""required"" />
                <xs:attribute name=""Implemented"" type=""xs:boolean"" />
              <xs:attribute name = ""Level"" type=""xs:integer"" />
              <xs:attribute name = ""Subtype"" type=""xs:string"" />
              <xs:attribute name = ""Prereq"" type=""xs:string"" />
              <xs:attribute name = ""SpellLike"" type=""xs:string"" />
              <xs:attribute name = ""Rogue"" type=""xs:integer"" />
              <xs:attribute name = ""Slayer"" type=""xs:integer"" />
              <xs:attribute name = ""Ninja"" type=""xs:integer"" />
              <xs:attribute name = ""Investigator"" type=""xs:integer"" />
              <xs:attribute name = ""Description"" type=""xs:string"" use=""required"" />
            </xs:complexType>
          </xs:element>
        </xs:choice>
      </xs:complexType>
    </xs:element>
  </xs:schema>
";
    }
}