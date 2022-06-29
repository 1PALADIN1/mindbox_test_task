namespace AreaLibrary.Figures
{
	/// <summary>
	/// Прямоугольник
	/// </summary>
	public class Rect : IFigure
	{
		private readonly float _sideA;
		private readonly float _sideB;

		public float Square => _sideA * _sideB;

		public Rect(float sideA, float sideB)
		{
			_sideA = sideA;
			_sideB = sideB;
		}

		public override string ToString()
		{
			return $"Rect [A = {_sideA}, B = {_sideB}]";
		}
	}
}