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

    public FigureAreaCalculator(FigureAreaCalculatorConfig config)
    {
        _calculators = new Dictionary<Type, IFigureAreaCalculator>();
        InitializeDictionary(config);
    }

    public double Calculate<T>(T figure)
    {
        var type = typeof(T);
        return _calculators[type].Calculate(figure);
    }

    private void InitializeDictionary(FigureAreaCalculatorConfig config = null)
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
        if (config is not null)
        {
            foreach (var pair in config.Calculators)
            {
                _calculators.Add(pair.Key, pair.Value);
            }
        }
    }
}
