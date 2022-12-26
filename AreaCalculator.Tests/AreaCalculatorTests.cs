using System.Collections;
using AreaCalculator.Core;
using AreaCalculator.Core.Models;
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
        var circle = new Circle();
        circle.Radius = 5;
        var expected = 78.5d;

        var result = _sut.Calculate(circle);

        result.Should().BeApproximately(expected, _precision);
    }

    [Fact]
    public void ShouldCaclulateTriangleArea() 
    {
        _sut = new();
        var triangle = new Triangle();
        triangle.SideA = 3;
        triangle.SideB = 4;
        triangle.SideC = 5;
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
}

public class RightTriangleTestData : IEnumerable<object[]>
{
    private List<object[]> _data = new List<object[]>() 
    {
        new object[] { new Triangle() {SideA = 3, SideB = 4, SideC = 5} },
        new object[] { new Triangle() {SideA = 3, SideB = 5, SideC = 4} },
        new object[] { new Triangle() {SideA = 5, SideB = 4, SideC = 3} },
        new object[] { new Triangle() {SideA = 5, SideB = 3, SideC = 4} },
        new object[] { new Triangle() {SideA = 4, SideB = 5, SideC = 3} },
        new object[] { new Triangle() {SideA = 4, SideB = 3, SideC = 5} }
    };

    public IEnumerator<object[]> GetEnumerator()
    {
        return _data.GetEnumerator();
    }

    IEnumerator IEnumerable.GetEnumerator() => GetEnumerator();
}