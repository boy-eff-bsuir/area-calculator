using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using AreaCalculator.Core.Interfaces;

namespace AreaCalculator.Core
{
    public class FigureAreaCalculatorConfig
    {
        public List<KeyValuePair<Type, IFigureAreaCalculator>> Calculators { get; }

        public FigureAreaCalculatorConfig()
        {
            Calculators = new List<KeyValuePair<Type, IFigureAreaCalculator>>();
        }

        public void Add(Type t, IFigureAreaCalculator calculator)
        {
            Calculators.Add(new(t, calculator));
        }
    }
}