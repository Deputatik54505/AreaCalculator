using System.Runtime.InteropServices;
using AreaCalculator.Shapes;
using Xunit;

namespace AreaCalculator.Tests;

public class TriangleTest
{
	[Theory]
	[InlineData(6, 3, 4, 5)]
	[InlineData(99.9949998,100,100,2)]
	[InlineData(1052761191.0244427, 54505, 54000, 100000)]
	[InlineData(1286391980.5432134, 54505, 54505, 54505)]
	public void Triangle_Area_ReturnsDouble(
		double expected, double a,
		double b, double c)
	{
		const double tolerance = 0.0005;
		var triangle = new Triangle(a, b, c);


		Assert.True(triangle.Area() - expected < tolerance);
	}
	
	[Fact]
	public void Triangle_Area_Fails()
	{
		double a = 101;
		double b = 100;
		double c = 0.001;

		try
		{
			new Triangle(a, b, c);
			Assert.Fail();
		}
		catch (ArgumentException)
		{
			Assert.True(true);
		}
		catch (Exception)
		{
			Assert.Fail();
		}
	}


	[Theory]
	[InlineData(true, 3, 4, 5)]
	[InlineData(true, 1, 1.4142135624, 1)]
	[InlineData(false, 54505, 54505, 54505)]
	[InlineData(false, 3, 4, 6)]
	public void Triangle_IsRectangular_ReturnsBool(
		bool expected, double a,
		double b, double c)
	{
		var triangle = new Triangle(a, b, c);

		Assert.Equal(expected,triangle.IsRectangular());
	}
}