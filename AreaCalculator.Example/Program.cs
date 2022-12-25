using AreaCalculator.Core;
using AreaCalculator.Core.Models;

var circle = new Triangle();
circle.SideA = 3;
circle.SideB = 4;
circle.SideC = 5;
var calculator = new FigureAreaCalculator();
Console.WriteLine(calculator.Calculate(circle));