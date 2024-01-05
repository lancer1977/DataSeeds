using Pathfinder.DocConverter.Exporters;
using PFAExcelToXML;

namespace Pathfinder.DocConverter.Generators
{
    public class TraitXml :  IGeneratorModel
    {
     
        public   string Name=> @"Trait";
        public   string Worksheet=> @"Traits";
        public   string OutputName=> @"traitdb.xml";
        public   string Header=> @"
   <xs:schema id=""root"" xmlns="""" xmlns:xs=""http://www.w3.org/2001/XMLSchema""
             xmlns:msdata=""urn:schemas-microsoft-com:xml-msdata"">
    <xs:element name = ""root"" msdata:IsDataSet=""true"" msdata:UseCurrentLocale=""true"">
      <xs:complexType>
        <xs:choice minOccurs = ""0"" maxOccurs=""unbounded"">
          <xs:element name = ""trait"" >
            <xs:complexType>
<xs:attribute name = ""Id"" type=""xs:integer"" />
              <xs:attribute name = ""Name"" type=""xs:string"" />
              <xs:attribute name = ""Imp"" type=""xs:boolean"" />
              <xs:attribute name = ""Options"" type=""xs:string"" />
              <xs:attribute name = ""BenefitType"" type=""xs:string"" />
              <xs:attribute name = ""BenefitAmount"" type=""xs:integer"" />
              <xs:attribute name = ""Benefit"" type=""xs:string"" />
              <xs:attribute name = ""Description"" type=""xs:string"" />
              <xs:attribute name = ""Category"" type=""xs:string"" />
              <xs:attribute name = ""Type"" type=""xs:string"" />
              <xs:attribute name = ""Prerequisites"" type=""xs:string"" />
              <xs:attribute name = ""PFS_Legal"" type=""xs:string"" />
              <xs:attribute name = ""Source"" type=""xs:string"" />
              <xs:attribute name = ""Version"" type=""xs:string"" />
            </xs:complexType>
          </xs:element>
        </xs:choice>
      </xs:complexType>
    </xs:element>
  </xs:schema>
";
    }
}