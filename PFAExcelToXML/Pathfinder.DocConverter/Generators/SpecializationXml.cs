using Pathfinder.DocConverter.Exporters;
using PFAExcelToXML;

namespace Pathfinder.DocConverter.Generators
{
    public class SpecializationXml : IGeneratorModel
    {

        public   string Name => @"Specialization";
        public   string Worksheet => @"Specialization";
        public   string OutputName => @"specializationdb.xml";
        public   string Header => @"
 <xs:schema id=""root"" xmlns="""" xmlns:xs=""http://www.w3.org/2001/XMLSchema"" xmlns:msdata=""urn:schemas-microsoft-com:xml-msdata"">
    <xs:element name = ""Specialization"" >
      <xs:complexType>
       <xs:attribute name = ""Id"" type=""xs:int""  use=""required""/>
        <xs:attribute name = ""Name"" type=""xs:string"" use=""required"" />
        <xs:attribute name = ""Type"" type=""xs:string"" use=""required"" />
        <xs:attribute name = ""Power1"" type=""xs:string"" />
        <xs:attribute name = ""Power2"" type=""xs:string"" />
        <xs:attribute name=""Implemented"" type=""xs:boolean"" />
        <xs:attribute name = ""Power3"" type=""xs:string"" />
        <xs:attribute name = ""Power4"" type=""xs:string"" />
        <xs:attribute name = ""Power5"" type=""xs:string"" />
        <xs:attribute name = ""Feat"" type=""xs:string"" />
        <xs:attribute name = ""Skill"" type=""xs:string"" />
        <xs:attribute name = ""Power"" type=""xs:string"" />
        <xs:attribute name = ""Subtype"" type=""xs:string"" />
        <xs:attribute name = ""Description"" type=""xs:string"" />
        <xs:attribute name = ""Spells"" type=""xs:string"" />
      </xs:complexType>
    </xs:element>
  </xs:schema>
";
    }
}