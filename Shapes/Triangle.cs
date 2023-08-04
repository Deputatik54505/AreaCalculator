namespace AreaCalculator;


public class Triangle : IArea
{
	private readonly double _aSide;
	private readonly double _bSide;
	private readonly double _cSide;

	public Triangle(double aSide, double bSide, double cSide)
	{
		_aSide = aSide;
		_bSide = bSide;
		_cSide = cSide;
	}

	public double Area()
	{
		var p = (_aSide + _bSide + _cSide) / 2;

		return Math.Sqrt(p * (p - _aSide) * (p - _bSide) * (p - _cSide));
	}

	/// <summary>
	/// Method checks if triangle has an 90 degrees angle
	/// by applying Pythagoras theorem 
	/// </summary>
	/// <returns> true if triangle has an right angle </returns>
	public bool IsRectangular()
	{
		var hypotenuse = Math.Max(_aSide, Math.Max(_bSide, _cSide));
		var leg1 = Math.Min(_aSide, Math.Min(_bSide, _cSide));
		var leg2 = _aSide + _bSide + _cSide - hypotenuse - leg1;

		return Math.Abs(Math.Pow(hypotenuse, 2) - (Math.Pow(leg1, 2) + Math.Pow(leg2, 2))) < 0.000001;
	}
}