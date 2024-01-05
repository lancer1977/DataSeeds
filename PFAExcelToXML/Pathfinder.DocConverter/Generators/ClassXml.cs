
using Pathfinder.DocConverter.Exporters;
using PFAExcelToXML;

namespace Pathfinder.DocConverter.Generators
{
 
    public class ClassXml :  IGeneratorModel
    {

        public   string Name => @"CharacterClass";
        public   string Worksheet => @"CharacterClass";
        public   string OutputName => @"classdb.xml";
        public   string Header => @"
   <xs:schema id=""root"" xmlns="""" xmlns:xs=""http://www.w3.org/2001/XMLSchema""
        xmlns:msdata=""urn:schemas-microsoft-com:xml-msdata"">
            <xs:element name = ""root"" msdata:IsDataSet=""true"" msdata:UseCurrentLocale=""true"">
                <xs:complexType>
                    <xs:choice minOccurs = ""0"" maxOccurs=""unbounded"">
                    <xs:element name = ""CharacterClass"" maxOccurs=""79228162514264337593543950335"">
                    <xs:complexType> 
                    <xs:attribute name = ""Name"" type=""xs:string"" use=""required"" />
                    <xs:attribute name = ""SpellStat"" type=""xs:string"" />
                    <xs:attribute name = ""CasterType"" type=""xs:string"" />
                    <xs:attribute name = ""AlternateClasses"" type=""xs:string"" />
                    <xs:attribute name = ""Hitdie"" type=""xs:integer"" use=""required"" />
                    <xs:attribute name = ""Fortitude"" type=""xs:string"" use=""required"" />
                    <xs:attribute name = ""Reflex"" type=""xs:string"" use=""required"" />
                    <xs:attribute name = ""Will"" type=""xs:string"" use=""required"" />
                    <xs:attribute name = ""Skillsperlevel"" type=""xs:integer"" use=""required"" />
                    <xs:attribute name = ""ClassSkills"" type=""xs:string"" use=""required"" />
                    <xs:attribute name = ""System"" type=""xs:string"" use=""required"" />
                    <xs:attribute name = ""Source"" type=""xs:string"" />
                    <xs:attribute name = ""License"" type=""xs:string"" use=""required"" />
                    <xs:attribute name = ""Description"" type=""xs:string"" />
                    <xs:attribute name = ""Type"" type=""xs:string"" use=""required"" />
                    <xs:attribute name = ""Bab"" type=""xs:string"" use=""required"" />
                    <xs:attribute name = ""Gold"" type=""xs:string"" />
                    </xs:complexType>
                    </xs:element>
                    </xs:choice>
                </xs:complexType>
            </xs:element>
        </xs:schema>
";
    }
     
}