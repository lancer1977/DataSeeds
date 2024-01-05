using Pathfinder.DocConverter.Exporters;
using PFAExcelToXML;

namespace Pathfinder.DocConverter.Generators
{
    public class MagicItemXml : IGeneratorModel
    {

        public   string Name => @"magicitem";
        public   string Worksheet => @"MagicItems";
        public   string OutputName => @"magicitemsdb.xml";
        public   string Header => @" 
  <xs:schema id=""root"" xmlns="""" xmlns:xs=""http://www.w3.org/2001/XMLSchema"" xmlns:msdata=""urn:schemas-microsoft-com:xml-msdata"">
    <xs:element name = ""root"" msdata:IsDataSet=""true"" msdata:UseCurrentLocale=""true"">
      <xs:complexType>
        <xs:choice minOccurs = ""0"" maxOccurs=""unbounded"">
          <xs:element name = ""magicitem"" >
            <xs:complexType>
              <xs:attribute name = ""Name"" type=""xs:string"" />
              <xs:attribute name = ""Effect"" type=""xs:string"" />
              <xs:attribute name = ""Implemented"" type=""xs:boolean"" />
              <xs:attribute name = ""Aura"" type=""xs:string"" />
              <xs:attribute name = ""CL"" type=""xs:string"" />
              <xs:attribute name = ""ItemType"" type=""xs:string"" />
              <xs:attribute name = ""Weight"" type=""xs:integer"" />
              <xs:attribute name = ""Description"" type=""xs:string"" />
              <xs:attribute name = ""Requirements"" type=""xs:string"" />
              <xs:attribute name = ""ItemCategory"" type=""xs:string"" />
              <xs:attribute name = ""Source"" type=""xs:string"" />
              <xs:attribute name = ""Cost"" type=""xs:integer"" />
              <xs:attribute name = ""AL"" type=""xs:string"" />
              <xs:attribute name = ""Int"" type=""xs:string"" />
              <xs:attribute name = ""Wis"" type=""xs:string"" />
              <xs:attribute name = ""Cha"" type=""xs:string"" />
              <xs:attribute name = ""Ego"" type=""xs:string"" />
              <xs:attribute name = ""Communication"" type=""xs:string"" />
              <xs:attribute name = ""Senses"" type=""xs:string"" />
              <xs:attribute name = ""Powers"" type=""xs:string"" />
              <xs:attribute name = ""MagicItems"" type=""xs:string"" />
              <xs:attribute name = ""Destruction"" type=""xs:string"" />
              <xs:attribute name = ""MinorArtifactFlag"" type=""xs:string"" />
              <xs:attribute name = ""MajorArtifactFlag"" type=""xs:string"" />
              <xs:attribute name = ""Abjuration"" type=""xs:string"" />
              <xs:attribute name = ""Conjuration"" type=""xs:string"" />
              <xs:attribute name = ""Divination"" type=""xs:string"" />
              <xs:attribute name = ""Enchantment"" type=""xs:string"" />
              <xs:attribute name = ""Evocation"" type=""xs:string"" />
              <xs:attribute name = ""Necromancy"" type=""xs:string"" />
              <xs:attribute name = ""Transmutation"" type=""xs:string"" />
              <xs:attribute name = ""AuraStrength"" type=""xs:string"" />
              <xs:attribute name = ""Languages"" type=""xs:string"" />
              <xs:attribute name = ""BaseItem"" type=""xs:string"" />
              <xs:attribute name = ""Id"" type=""xs:string"" />
            </xs:complexType>
          </xs:element>
        </xs:choice>
      </xs:complexType>
    </xs:element>
  </xs:schema>
";
    }
}