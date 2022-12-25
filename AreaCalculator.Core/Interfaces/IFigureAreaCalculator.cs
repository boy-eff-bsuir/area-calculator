namespace AreaCalculator.Core.Interfaces
{
    public interface IFigureAreaCalculator
    {
        Type FigureType { get; init; }
        double Calculate(object figure);
    }
}