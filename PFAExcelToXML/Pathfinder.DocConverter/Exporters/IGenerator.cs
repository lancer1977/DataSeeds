namespace Pathfinder.DocConverter.Exporters
{
    public interface IGenerator
    {
        string GenerateData(IGeneratorModel destination);
        string GenerateEnum(IGeneratorModel destination);
        string Extension { get; }
    }
}