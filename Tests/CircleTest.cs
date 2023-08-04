using AreaCalculator.Shapes;
using Xunit;

namespace AreaCalculator.Tests;

public class CircleTest
{
	[Theory]
	[InlineData(Math.PI,1)]
	[InlineData(Math.PI*2.25,1.5 )]
	public void Circle_Area_ReturnsDouble(double expected, double radius)
	{
		var circle = new Circle(radius);

		Assert.Equal(expected, circle.Area());
	}
}