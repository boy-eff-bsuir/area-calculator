using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using AreaCalculator.Core.Interfaces;

namespace AreaCalculator.Core.Models
{
    public class Circle
    {
        private double _radius;
        public Circle(double radius)
        {
            this.Radius = radius;
        }

        public double Radius { 
            get
            {
                return _radius;
            } 
            set
            {
                if (value > 0)
                {
                    _radius = value;
                }
                else
                {
                    throw new ArgumentOutOfRangeException($"Radius should be a positive value, but received {value}");
                }
            } 
        }
    }
}