using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using AreaCalculator.Core.Interfaces;

namespace AreaCalculator.Example.Calculators
{
    public class IntCalculator : IFigureAreaCalculator
    {
        public Type FigureType { get; } = typeof(int);

        public double Calculate(object figure)
        {
            var digit = (int)figure;
            return digit * digit;
        }
    }
}