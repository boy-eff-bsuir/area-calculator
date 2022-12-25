using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using AreaCalculator.Core.Interfaces;

namespace AreaCalculator.Core.Models
{
    public class TriangleAreaCalculator : IFigureAreaCalculator
    {
        public double SideA { get; set; }
        public double SideB { get; set; }
        public double SideC { get; set; }
        public double Calculate()
        {
            var p = SideA + SideB + SideC / 2;
            return Math.Sqrt(p * (p - SideA) * (p - SideB) * (p - SideC));
        }
    }
}