using System.Collections.Concurrent;
using AreaCalculator.Core.Interfaces;

namespace AreaCalculator.Core;
public class FigureAreaCalculator
{
    private Dictionary<Type, IFigureAreaCalculator> _dictionary;
    public double Calculate<T>(T figure)
    {
        return _dictionary[typeof(T)].Calculate();
    }
}
