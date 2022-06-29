using System;

namespace AreaLibrary.Figures
{
	public class Triangle : IFigure
	{
		private const float CalcError = 0.00001f;
		
		private readonly float _sideA;
		private readonly float _sideB;
		private readonly float _sideC;

		public float Square
		{
			get
			{
				var halfP = (_sideA + _sideB + _sideC) / 2f; //полупериметр
				return (float)Math.Sqrt(halfP * (halfP - _sideA) * (halfP - _sideB) * (halfP - _sideC));
			}
		}
		
		public bool IsRightAngled => Math.Abs(_sideA * _sideA + _sideB * _sideB - _sideC * _sideC) < CalcError;

		public Triangle(float sideA, float sideB, float sideC)
		{
			_sideA = sideA;
			_sideB = sideB;
			_sideC = sideC;
		}

		public override string ToString()
		{
			return $"Triangle [A = {_sideA}, B = {_sideB}, C = {_sideC}]";
		}
	}
}