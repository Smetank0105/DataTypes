using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RhombusAndChess
{
	class Program
	{
		static void Main(string[] args)
		{
			Console.WriteLine("Введите размер фигур: ");
			int size = Convert.ToInt32(Console.ReadLine());

			//ромб
			for(int i = 0; i < size*2; i++)
			{
				if (i < size) Console.WriteLine("/".PadLeft(size - i) + "\\".PadLeft(i * 2 + 1));
				else Console.WriteLine("\\".PadLeft(i-size + 1) + "/".PadLeft((size*2 - i) * 2 - 1));
			}
			Console.WriteLine();

			//шахматы
			int key = 1;								//ключ для переключения между звездой и пробелом
			for(int i = 0; i < size * 8; i++)
			{
				if (i % size == 0) key = -key;			//каждый раз, когда i кратно высоте кубика, переключает ключ

				for (int j = 0; j < size * 8; j++)
				{
					if (j % size == 0) key = -key;		//каждый раз, когда j кратно ширине кубика, переключает ключ

					if (key > 0) Console.Write("* ");	//если ключ 1, рисует звезду
					else Console.Write("  ");			//если ключ -1, рисует пробел
				}
				Console.WriteLine();					//перевод строки
			}
		}
	}
}
