using Pathfinder.DocConverter.Exporters;
using PFAExcelToXML;

namespace Pathfinder.DocConverter.Generators
{
    public class SpellXml :  IGeneratorModel
    {

        public  string Name=> @"Spell";
        public  string Worksheet => @"Spells";
        public  string OutputName => @"spelldb.xml";
        public  string Header => @"
<xs:schema id=""root"" xmlns="""" xmlns:xs=""http://www.w3.org/2001/XMLSchema"" xmlns:msdata=""urn:schemas-microsoft-com:xml-msdata"">
    <xs:element name = ""root"" msdata:IsDataSet=""true"" msdata:UseCurrentLocale=""true"">
      <xs:complexType>
        <xs:choice minOccurs = ""0"" maxOccurs=""unbounded"">
          <xs:element name = ""Spell"" >
            <xs:complexType>
               <xs:attribute name=""Id"" type=""xs:int""  use=""required""/>
              <xs:attribute name=""Implemented"" type=""xs:boolean""  />              
              <xs:attribute name=""Name"" type=""xs:string"" />
              <xs:attribute name=""Duration"" type=""xs:string"" />
              <xs:attribute name=""School"" type=""xs:string"" />
              <xs:attribute name=""Subschool"" type=""xs:string"" />
              <xs:attribute name=""Effect"" type=""xs:string"" />
              <xs:attribute name=""EffectType"" type=""xs:string"" />
              <xs:attribute name=""SpellType"" type=""xs:string"" />
              <xs:attribute name=""CastingTime"" type=""xs:string"" />
              <xs:attribute name=""Components"" type=""xs:string"" />
              <xs:attribute name=""Range"" type=""xs:string"" />
              <xs:attribute name=""Area"" type=""xs:string"" />
              <xs:attribute name=""Targets"" type=""xs:string"" />
              <xs:attribute name=""SavingThrow"" type=""xs:string"" />
              <xs:attribute name=""Harmless"" type=""xs:boolean"" />
              <xs:attribute name=""Resistance"" type=""xs:boolean"" />
              <xs:attribute name=""Description"" type=""xs:string"" />
              <xs:attribute name=""Source"" type=""xs:string"" />
              <xs:attribute name=""CostlyComponents"" type=""xs:integer"" />
              <xs:attribute name=""Dismissible"" type=""xs:integer"" />
              <xs:attribute name=""Shapeable"" type=""xs:integer"" />
              <xs:attribute name=""verbal"" type=""xs:integer"" />
              <xs:attribute name=""somatic"" type=""xs:integer"" />
              <xs:attribute name=""material"" type=""xs:integer"" />
              <xs:attribute name=""focus"" type=""xs:integer"" />
              <xs:attribute name=""divine_focus"" type=""xs:integer"" />
              <xs:attribute name=""sor"" type=""xs:integer"" />
              <xs:attribute name=""wiz"" type=""xs:integer"" />
              <xs:attribute name=""cleric"" type=""xs:integer"" />
              <xs:attribute name=""druid"" type=""xs:integer"" />
              <xs:attribute name=""ranger"" type=""xs:integer"" />
              <xs:attribute name=""bard"" type=""xs:integer"" />
              <xs:attribute name=""paladin"" type=""xs:integer"" />
              <xs:attribute name=""alchemist"" type=""xs:integer"" />
              <xs:attribute name=""summoner"" type=""xs:integer"" />
              <xs:attribute name=""witch"" type=""xs:integer"" />
              <xs:attribute name=""inquisitor"" type=""xs:integer"" />
              <xs:attribute name=""oracle"" type=""xs:integer"" />
              <xs:attribute name=""antipaladin"" type=""xs:integer"" />
              <xs:attribute name=""magus"" type=""xs:integer"" />
              <xs:attribute name=""SLA_Level"" type=""xs:integer"" />
              <xs:attribute name=""domain"" type=""xs:string"" />
              <xs:attribute name=""Sdescription"" type=""xs:string"" /> 
            </xs:complexType>
          </xs:element>
        </xs:choice>
      </xs:complexType>
    </xs:element>
  </xs:schema>
";
    }
}