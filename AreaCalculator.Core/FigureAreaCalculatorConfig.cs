using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using AreaCalculator.Core.Interfaces;

namespace AreaCalculator.Core
{
    public class FigureAreaCalculatorConfig
    {
        public List<KeyValuePair<Type, Type>> Calculators { get; }

        public FigureAreaCalculatorConfig()
        {
            Calculators = new List<KeyValuePair<Type, Type>>();
        }

        public void Add<TFigure, TCalculator>() 
            where TCalculator : IAreaCalculator
        {
            Calculators.Add(new(typeof(TFigure), typeof(TCalculator)));
        }
    }
}