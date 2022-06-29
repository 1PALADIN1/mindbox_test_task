using System;
using AreaLibrary.Figures;
using NUnit.Framework;

namespace UnitTests
{
	public class Tests
	{
		private const float CalcError = 0.00001f; //погрешность при вычислении площади

		[Test]
		public void CircleSquareTest()
		{
			var circle = new Circle(20);
			var result = Math.Abs(circle.Square - 1256.6371f) < CalcError;
			Assert.True(result);
		}
		
		[Test]
		public void TriangleSquareTest()
		{
			var triangle = new Triangle(3f, 4f, 5f);
			var result = Math.Abs(triangle.Square - 6f) < CalcError;
			Assert.True(result);
		}
		
		[Test]
		public void RectSquareTest()
		{
			var rect = new Rect(12f, 10f);
			var result = Math.Abs(rect.Square - 120f) < CalcError;
			Assert.True(result);
		}
	}
}