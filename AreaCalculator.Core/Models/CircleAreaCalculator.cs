using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using AreaCalculator.Core.Exceptions;
using AreaCalculator.Core.Interfaces;

namespace AreaCalculator.Core.Models
{
    public class CircleAreaCalculator : IAreaCalculator
    {
        public Type FigureType { get; } = typeof(Circle);

        public double Calculate(object figure)
        {
            if (figure.GetType() == this.FigureType)
            {
                var circle = (Circle) figure;
                return Math.PI * circle.Radius * circle.Radius;
            }
            else 
            {
                throw new TypeMismatchException("Invalid type");
            }
        }
    }
}