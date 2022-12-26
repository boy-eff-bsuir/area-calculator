using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using AreaCalculator.Core.Interfaces;

namespace AreaCalculator.Core.Models
{
    public class Triangle
    {
        public Triangle(double sideA, double sideB, double sideC)
        {
            SetSides(sideA, sideB, sideC);
        }

        public double SideA { get; private set; }
        public double SideB { get; private set; }
        public double SideC { get; private set; }

        public void SetSides(double sideA, double sideB, double sideC) 
        {
            ValidateTriangle(sideA, sideB, sideC);
            SideA = sideA;
            SideB = sideB;
            SideC = sideC;
        }

        private void ValidateTriangle(double sideA, double sideB, double sideC) 
        {
            if (sideA <= 0)
            {
                throw new ArgumentOutOfRangeException($"Argument sideA should be a positive number, received {sideA}");
            }
            if (sideB <= 0)
            {
                throw new ArgumentOutOfRangeException($"Argument sideB should be a positive number, received {sideB}");
            }
            if (sideC <= 0)
            {
                throw new ArgumentOutOfRangeException($"Argument sideC should be a positive number, received {sideC}");
            }
            if ((sideA >= sideB + sideC) || (sideB >= sideA + sideC) || (sideC >= sideA + sideB))
            {
                throw new ArgumentException("Invalid triangle");
            }
        }
    }
}