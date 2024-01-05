using Pathfinder.DocConverter.Exporters;
using PFAExcelToXML;

namespace Pathfinder.DocConverter.Generators
{
    public class ClassTraitXml : IGeneratorModel
    {

        public   string Name => @"CF";
        public   string Worksheet => @"ClassTrait";
        public   string OutputName => @"classfeaturesdb";
        public   string Header => @"
    <xs:schema id=""root"" xmlns="""" xmlns:xs=""http://www.w3.org/2001/XMLSchema""
             xmlns:msdata=""urn:schemas-microsoft-com:xml-msdata"">
    <xs:element name = ""root"" msdata:IsDataSet=""true"" msdata:UseCurrentLocale=""true"">
      <xs:complexType>
        <xs:choice minOccurs = ""0"" maxOccurs=""unbounded"">
          <xs:element name = ""CF"" maxOccurs=""79228162514264337593543950335"">
            <xs:complexType>
              <xs:attribute name = ""Id"" type=""xs:int""  use=""required""/>
              <xs:attribute name = ""Name"" type=""xs:string"" use=""required"" />
              <xs:attribute name = ""Archtype"" type=""xs:string"" use=""required"" />
              <xs:attribute name = ""SpellLike"" type=""xs:string"" />
              <xs:attribute name = ""Level"" type=""xs:int"" use=""required"" />
              <xs:attribute name = ""Sacrifice"" type=""xs:string"" />
              <xs:attribute name = ""Implemented"" type=""xs:boolean"" />
              <xs:attribute name = ""LevelsPerCharges"" type=""xs:int"" />
              <xs:attribute name = ""Calculation"" type=""xs:string"" />
              <xs:attribute name = ""Description"" type=""xs:string"" />
              <xs:attribute name = ""Class"" type=""xs:string"" use=""required"" />
            </xs:complexType>
          </xs:element>
        </xs:choice>
      </xs:complexType>
    </xs:element>
  </xs:schema>
";
    }
     
}