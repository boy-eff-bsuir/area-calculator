namespace AreaCalculator.Core.Interfaces
{
    public interface IFigureAreaCalculator
    {
        Type FigureType { get; }
        double Calculate(object figure);
    }
}