using AreaCalculator.Core;
using AreaCalculator.Core.Models;
using AreaCalculator.Example.Calculators;

var config = new FigureAreaCalculatorConfig();
var intCalculator = new IntCalculator();
config.Add(typeof(int), intCalculator);
var calculator = new FigureAreaCalculator(config);
Console.WriteLine(calculator.Calculate(2));