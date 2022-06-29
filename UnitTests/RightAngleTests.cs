using AreaLibrary.Figures;
using NUnit.Framework;

namespace UnitTests
{
	public class RightAngleTests
	{
		[Test]
		public void RightAngle()
		{
			var triangle = new Triangle(3, 4, 5);
			Assert.True(triangle.IsRightAngled);
		}
		
		[Test]
		public void NotRightAngle()
		{
			var triangle = new Triangle(5, 5, 5);
			Assert.False(triangle.IsRightAngled);
		}
	}
}