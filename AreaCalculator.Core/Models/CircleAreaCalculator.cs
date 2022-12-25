using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using AreaCalculator.Core.Interfaces;

namespace AreaCalculator.Core.Models
{
    public class CircleAreaCalculator : IFigureAreaCalculator
    {
        public double Radius { get; set; }
        public double Calculate()
        {
            return Math.PI * Radius * Radius;
        }
    }
}