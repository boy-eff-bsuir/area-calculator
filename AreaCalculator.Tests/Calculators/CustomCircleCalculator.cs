using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using AreaCalculator.Core.Interfaces;
using AreaCalculator.Core.Models;

namespace AreaCalculator.Tests.Calculators
{
    public class CustomCircleCalculator : IAreaCalculator
    {
        public Type FigureType { get; } = typeof(Circle);

        public double Calculate(object figure)
        {
            return 1;
        }
    }
}