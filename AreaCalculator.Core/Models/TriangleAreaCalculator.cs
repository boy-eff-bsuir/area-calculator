using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using AreaCalculator.Core.Exceptions;
using AreaCalculator.Core.Interfaces;

namespace AreaCalculator.Core.Models
{
    public class TriangleAreaCalculator : IAreaCalculator
    {
        public Type FigureType { get; } = typeof(Triangle);

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
                throw new TypeMismatchException("Invalid type");
            } 
        }
    }
}