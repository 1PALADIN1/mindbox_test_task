using System;

namespace AreaLibrary.Figures
{
	public class Circle : IFigure
	{
		private readonly float _radius;

		public float Square => (float)Math.PI * _radius * _radius;

		public Circle(float radius)
		{
			_radius = radius;
		}

		public override string ToString()
		{
			return $"Circle [radius {_radius}]";
		}
	}
}