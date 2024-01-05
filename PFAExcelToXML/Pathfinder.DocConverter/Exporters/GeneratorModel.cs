namespace Pathfinder.DocConverter.Exporters
{
    public interface IGeneratorModel
    {
        string Header { get; }
        string Name { get; }
        string Worksheet { get; }
        string OutputName { get; }
    }
}