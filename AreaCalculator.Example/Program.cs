using AreaCalculator.Core;
using AreaCalculator.Core.Models;
using AreaCalculator.Example.Calculators;

var config = new FigureAreaCalculatorConfig();
var intCalculator = new IntCalculator();
var triangle = new Triangle(3, 4, 5);
config.Add(typeof(int), intCalculator);
var calculator = new FigureAreaCalculator(config);
Console.WriteLine(calculator.IsTriangleRight(triangle));