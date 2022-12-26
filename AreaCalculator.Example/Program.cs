using AreaCalculator.Core;
using AreaCalculator.Core.Models;
using AreaCalculator.Example.Calculators;

var config = new FigureAreaCalculatorConfig();
var intCalculator = new IntCalculator();
var triangle = new Triangle();
triangle.SideA = 3;
triangle.SideB = 4;
triangle.SideC = 6;
config.Add(typeof(int), intCalculator);
var calculator = new FigureAreaCalculator(config);
Console.WriteLine(calculator.IsTriangleRight(triangle));