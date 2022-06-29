using System;
using AreaLibrary.Figures;

namespace AreaLibraryClient
{
	/*
	 * Напишите на C# библиотеку для поставки внешним клиентам, которая умеет вычислять
	 * площадь круга по радиусу и треугольника по трем сторонам. Дополнительно к работоспособности оценим:
	 * * Юнит-тесты
	 * * Легкость добавления других фигур
	 * * Вычисление площади фигуры без знания типа фигуры в compile-time
	 * * Проверку на то, является ли треугольник прямоугольным
	 */
	
	public static class Program
	{
		private static void Main(string[] args)
		{
			var figures = new IFigure[]
			{
				new Circle(20f),
				new Triangle(3f, 4f, 5f),
				new Rect(12, 10)
			};
			
			Console.WriteLine("Squares:");
			foreach (var figure in figures)
				Console.WriteLine($"\t{figure}: {figure.Square}");
		}
	}
}