using Pathfinder.DocConverter.Exporters;
using PFAExcelToXML;

namespace Pathfinder.DocConverter.Generators
{
    public class WeaponFeatureXml : IGeneratorModel
    {
     
        public   string Name => @"WeaponFeature";
        public   string Worksheet => @"WeaponFeatures";
        public   string OutputName => @"skilldb.xml";
        public   string Header => @"
  <xs:schema id = ""NewDataSet"" xmlns="""" xmlns:xs=""http://www.w3.org/2001/XMLSchema"" xmlns:msdata=""urn:schemas-microsoft-com:xml-msdata"">
    <xs:element name = ""NewDataSet"" msdata:IsDataSet=""true"" msdata:UseCurrentLocale=""true"">
      <xs:complexType>
        <xs:choice minOccurs = ""0"" maxOccurs=""unbounded"">
          <xs:element name = ""WeaponFeature"" >
            <xs:complexType>
 <xs:attribute name = ""Id"" type=""xs:int""  use=""required""/>
              <xs:attribute name = ""Name"" type=""xs:string"" use=""required"" />
              <xs:attribute name = ""Aura"" type=""xs:string"" use=""required"" />
            
              <xs:attribute name = ""CL"" type=""xs:string"" use=""required"" />
              <xs:attribute name = ""Craft"" type=""xs:string"" use=""required"" />
              <xs:attribute name = ""Price"" type=""xs:string"" use=""required"" /> 

  <xs:attribute name = ""Description"" type=""xs:string""/>
            </xs:complexType>
          </xs:element>
        </xs:choice>
      </xs:complexType>
    </xs:element>
  </xs:schema>
";
    }
}