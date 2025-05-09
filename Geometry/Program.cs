using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Geometry
{
	class Program
	{
		static void Main(string[] args)
		{
			Console.WriteLine("Введите размер фигур: ");
			int size = Convert.ToInt32(Console.ReadLine());

			//квадрат
			for (int i = 0; i < size; i++)
			{
				for(int j = 0; j < size; j++)
				{
					Console.Write($"* ");
				}
				Console.WriteLine();
			}
			Console.WriteLine();

			//треугольники 1,2,3,4
			//1
			for(int i = 0; i < size; i++)
			{
				for(int j = 0; j < i+1; j++)
				{
					Console.Write($"* ");
				}
				Console.WriteLine();
			}
			Console.WriteLine();

			//2
			for (int i = 0; i < size; i++)
			{
				for (int j = 0; j < size-i; j++)
				{
					Console.Write($"* ");
				}
				Console.WriteLine();
			}
			Console.WriteLine();

			//3
			for (int i = 0; i < size; i++)
			{
				for (int j = 0; j < size-i; j++)
				{
					Console.Write($"* ");
				}
				Console.WriteLine();
				Console.Write("".PadLeft((i+1)*2)); //дополняет исходную строку символами слева в кол-ве (i+1)*2
			}
			Console.WriteLine();

			//4
			for (int i = 0; i < size; i++)
			{
				Console.Write("".PadLeft((size-1-i) * 2));  //дополняет исходную строку пробелами слева в кол-ве (size-1-i) * 2
				for (int j = 0; j < i+1; j++)
				{
					Console.Write($"* ");
				}
				Console.WriteLine();
			}
			Console.WriteLine();

			//ромб
			for(int i = 0; i < size; i++)	//верхняя половина ромба
			{
				Console.WriteLine("/".PadLeft(size - i)+"\\".PadLeft(i*2+1));
			}
			for (int i = 0; i < size; i++)	//нижняя половина ромба
			{
				Console.WriteLine("\\".PadLeft(i+1) + "/".PadLeft((size-i) * 2-1));
			}
			Console.WriteLine();

			//шахматы
			for(int i = 0; i < 8; i++)
			{
				for(int j = 0; j < size; j++)
				{
					for(int k = 0; k < 8; k++)
					{
						for(int n = 0; n < size; n++)
						{
							if((i%2 == 0 & k%2 == 0) | (i % 2 != 0 & k % 2 != 0))	//когда обе координаты "куба" чётные или наоборот нечётные
								Console.Write("* ");
							if ((i % 2 == 0 & k % 2 != 0) | (i % 2 != 0 & k % 2 == 0))	//когда одна координата "куба" чётная, а вторая нет
								Console.Write("  ");

						}
					}
					Console.WriteLine();
				}
			}
		}
	}
}
