using System.Collections.Concurrent;
using System.Reflection;
using AreaCalculator.Core.Interfaces;
using AreaCalculator.Core.Models;

namespace AreaCalculator.Core;
public class FigureAreaCalculator
{
    private Dictionary<Type, IAreaCalculator> _calculators;

    public FigureAreaCalculator()
    {
        _calculators = new Dictionary<Type, IAreaCalculator>();
        InitializeDictionary();
    }

    public FigureAreaCalculator(FigureAreaCalculatorConfig config)
    {
        _calculators = new Dictionary<Type, IAreaCalculator>();
        InitializeDictionary(config);
    }

    public double Calculate<T>(T figure)
    {
        var type = typeof(T);
        return _calculators[type].Calculate(figure);
    }

    public bool IsTriangleRight(Triangle triangle)
    {
        double largestSide = triangle.SideA;
        double bSide = triangle.SideB;
        double cSide = triangle.SideC;
        double temp;
        if (bSide > largestSide)
        {
            temp = bSide;
            bSide = largestSide;
            largestSide = temp;
        }
        if (cSide > largestSide)
        {
            temp = cSide;
            cSide = largestSide;
            largestSide = temp;
        }
        return (largestSide * largestSide) == (bSide * bSide) + (cSide * cSide);
    }

    private void InitializeDictionary(FigureAreaCalculatorConfig config = null)
    {
        var assembly = Assembly.GetExecutingAssembly();
        var types = assembly.GetTypes();
        foreach (var type in types)
        {
            if (type.IsAssignableTo(typeof(IAreaCalculator)) && type.IsClass)
            {
                var calculator = (IAreaCalculator) Activator.CreateInstance(type);
                _calculators[calculator.FigureType] = calculator;
            }
        }
        if (config is not null)
        {
            foreach (var pair in config.Calculators)
            {
                var calculator = (IAreaCalculator)Activator.CreateInstance(pair.Value);
                _calculators[pair.Key] = calculator;
            }
        }
    }
}
