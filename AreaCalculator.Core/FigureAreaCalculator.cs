using System.Collections.Concurrent;
using System.Reflection;
using AreaCalculator.Core.Interfaces;

namespace AreaCalculator.Core;
public class FigureAreaCalculator
{
    private Dictionary<Type, IFigureAreaCalculator> _calculators;

    public FigureAreaCalculator()
    {
        _calculators = new Dictionary<Type, IFigureAreaCalculator>();
        InitializeDictionary();
    }

    public double Calculate<T>(T figure)
    {
        var type = typeof(T);
        return _calculators[type].Calculate(figure);
    }

    private void InitializeDictionary()
    {
        var assembly = Assembly.GetExecutingAssembly();
        var types = assembly.GetTypes();
        foreach (var type in types)
        {
            if (type.IsAssignableTo(typeof(IFigureAreaCalculator)) && type.IsClass)
            {
                var calculator = (IFigureAreaCalculator) Activator.CreateInstance(type);
                _calculators.Add(calculator.FigureType, calculator);
            }
        }
    }
}
