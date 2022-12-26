namespace AreaCalculator.Core.Interfaces
{
    public interface IAreaCalculator
    {
        Type FigureType { get; }
        double Calculate(object figure);
    }
}