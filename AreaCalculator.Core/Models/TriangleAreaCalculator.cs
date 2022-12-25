using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using AreaCalculator.Core.Interfaces;

namespace AreaCalculator.Core.Models
{
    public class TriangleAreaCalculator : IFigureAreaCalculator
    {
        public Type FigureType { get; init; } = typeof(Triangle);

        public double Calculate(object figure)
        {
            if (figure.GetType() == this.FigureType)
            {
                var triangle = (Triangle) figure;
                var p = (triangle.SideA + triangle.SideB + triangle.SideC) / 2;
                return Math.Sqrt(p * (p - triangle.SideA) * (p - triangle.SideB) * (p - triangle.SideC));
            }
            else 
            {
                throw new Exception("Invalid type");
            } 
        }
    }
}