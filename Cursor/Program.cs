using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Cursor
{
	class Program
	{
		static void Main(string[] args)
		{
			Console.SetWindowSize(50, 25);				//размеры окна консоли

			ConsoleKey key;
			int cursorTop = 0, cursorLeft = 0;			//начальные координаты курсора
			do
			{
				Console.WriteLine('@');					//отображение текущей позиции курсора символом @

				key = Console.ReadKey(true).Key;
				switch (key)
				{
					case ConsoleKey.UpArrow:
					case ConsoleKey.W:
						cursorTop -= 1;					//смещение координат курсора в нужную сторону на 1 позицию
						break;
					case ConsoleKey.DownArrow:
					case ConsoleKey.S:
						cursorTop += 1;
						break;
					case ConsoleKey.LeftArrow:
					case ConsoleKey.A:
						cursorLeft -= 1;
						break;
					case ConsoleKey.RightArrow:
					case ConsoleKey.D:
						cursorLeft += 1;
						break;
					default:
						break;
				}

				Console.Clear();						//очистка экрана

				if (cursorTop < 0) cursorTop = 25;		//условия границ для курсора (при выходе в отрицательные значения, курсор перескакивает в противоположный конец окна консоли)
				if (cursorLeft < 0) cursorLeft = 50;

				//переход курсора на новую позицию, %50 и %25 ограничивают передвижения размерами окна консоли
				Console.SetCursorPosition(cursorLeft%50, cursorTop%25);

			} while (key != ConsoleKey.Escape);
		}
	}
}
