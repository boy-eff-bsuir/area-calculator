using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using AreaCalculator.Core.Interfaces;

namespace AreaCalculator.Core
{
    public class FigureAreaCalculatorConfig
    {
        public List<KeyValuePair<Type, IAreaCalculator>> Calculators { get; }

        public FigureAreaCalculatorConfig()
        {
            Calculators = new List<KeyValuePair<Type, IAreaCalculator>>();
        }

        public void Add(Type t, IAreaCalculator calculator)
        {
            Calculators.Add(new(t, calculator));
        }
    }
}