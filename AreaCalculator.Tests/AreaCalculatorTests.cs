using System.Collections;
using AreaCalculator.Core;
using AreaCalculator.Core.Models;
using AreaCalculator.Tests.Calculators;
using FluentAssertions;

namespace AreaCalculator.Tests;

public class AreaCalculatorTests
{
    private FigureAreaCalculator _sut;
    private double _precision = 0.1;

    [Fact]
    public void ShouldCalculateCircleArea()
    {
        _sut = new();
        var circle = new Circle(5);
        circle.Radius = 5;
        var expected = 78.5d;

        var result = _sut.Calculate(circle);

        result.Should().BeApproximately(expected, _precision);
    }

    [Fact]
    public void ShouldCaclulateTriangleArea() 
    {
        _sut = new();
        var triangle = new Triangle(3, 4, 5);
        var expected = 6d;

        var result = _sut.Calculate(triangle);

        result.Should().BeApproximately(expected, _precision);
    }

    [Theory]
    [ClassData(typeof(RightTriangleTestData))]
    public void ShouldCheckIfTriangleIsRight(Triangle triangle)
    {
        _sut = new();

        var result = _sut.IsTriangleRight(triangle);

        result.Should().BeTrue();
    }

    [Fact]
    public void ShouldUpdateCalculatorValue()
    {
        var config = new FigureAreaCalculatorConfig();
        var circle = new Circle(10);
        var expected = 1d;
        config.Add<Circle, CustomCircleCalculator>();
        _sut = new(config);
        
        var result = _sut.Calculate(circle);

        result.Should().BeApproximately(expected, _precision);
    }
}

public class RightTriangleTestData : IEnumerable<object[]>
{
    private List<object[]> _data = new List<object[]>() 
    {
        new object[] { new Triangle(3, 4, 5) },
        new object[] { new Triangle(3, 5, 4) },
        new object[] { new Triangle(5, 4, 3) },
        new object[] { new Triangle(5, 3, 4) },
        new object[] { new Triangle(4, 5, 3) },
        new object[] { new Triangle(4, 3, 5) }
    };

    public IEnumerator<object[]> GetEnumerator()
    {
        return _data.GetEnumerator();
    }

    IEnumerator IEnumerable.GetEnumerator() => GetEnumerator();
}