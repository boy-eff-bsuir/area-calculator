using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using AreaCalculator.Core.Interfaces;

namespace AreaCalculator.Core.Models
{
    public class CircleAreaCalculator : IFigureAreaCalculator
    {
        public Type FigureType { get; init; } = typeof(Circle);

        public double Calculate(object figure)
        {
            if (figure.GetType() == this.FigureType)
            {
                var circle = (Circle) figure;
                return Math.PI * circle.Radius * circle.Radius;
            }
            else 
            {
                throw new Exception("Invalid type");
            }
        }
    }
}