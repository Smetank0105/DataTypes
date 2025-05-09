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
			Console.SetWindowSize(50, 25);

			ConsoleKey key;
			int cursorTop = 0, cursorLeft = 0;
			do
			{
				Console.WriteLine('@');
				key = Console.ReadKey(true).Key;
				switch (key)
				{
					case ConsoleKey.UpArrow:
					case ConsoleKey.W:
						cursorTop -= 1;
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
				Console.Clear();
				if (cursorTop < 0) cursorTop = 25;
				if (cursorLeft < 0) cursorLeft = 50;
				Console.SetCursorPosition(cursorLeft%50, cursorTop%25);
			} while (key != ConsoleKey.Escape);
		}
	}
}
