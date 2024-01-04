// See https://aka.ms/new-console-template for more information

using CsvHelper;
using System.Globalization;
using System.Text.Json;
using System.Xml;

static List<T> ReadCsv<T>(string filePath)
{
    using (var reader = new StreamReader(filePath))
    using (var csv = new CsvReader(reader, CultureInfo.InvariantCulture))
    {
        // Automatically map CSV columns to properties of the specified class
        return csv.GetRecords<T>().ToList();
    }
}

static void WriteJson(string filePath, object data)
{
    string jsonData = JsonSerializer.Serialize(data, new JsonSerializerOptions
    {
        WriteIndented = true
    });
    // Write JSON data to the specified file
    File.WriteAllText(filePath, jsonData);
}

Console.WriteLine("Hello, World!");
#if DEBUG

var filename = "platform.csv";
string csvFilePath = filename;
string jsonFilePath = "platform.json";
#else
var filename = args[0]; 
string csvFilePath = filename;
string jsonFilePath = args[1];
#endif

//Create a text reader from a file




List<dynamic> data = ReadCsv<dynamic>(csvFilePath);

if (data != null)
{
    WriteJson(jsonFilePath, data);
}

 