using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Calculator
{
	class Program
	{
		static void Main(string[] args)
		{
			double A = 0.0, B = 0.0, Result = 0.0;
			char Key = '+'; //хранит символ операции, выбранной пользователем

			do
			{
				Console.Clear();
				Console.WriteLine("---Самый лучший в мире калькулятор!---");

				Console.WriteLine("Введите первое число: ");
				A = Convert.ToDouble(Console.ReadLine());

				Console.WriteLine("Введите второе число: ");
				B = Convert.ToDouble(Console.ReadLine());

				Console.WriteLine("Введите оператор (+,-,/,*): ");
				Key = Convert.ToChar(Console.ReadLine());

				switch (Key)
				{
					case '+':
						Result = A + B;
						Console.WriteLine($"Сумма {A} + {B} = {Result}");
						break;
					case '-':
						Result = A - B;
						Console.WriteLine($" Разность {A} - {B} = {Result}");
						break;
					case '/':
						Result = A / B;
						Console.WriteLine($"Деление {A} / {B} = {Result}");
						break;
					case '*':
						Result = A * B;
						Console.WriteLine($"Умножение {A} * {B} = {Result}");
						break;
					default:
						Console.WriteLine("Некорректный ввод!");
						break;
				}

				Console.WriteLine("Продолжить (Y/N)?");
				Key = Convert.ToChar(Console.ReadLine());

			} while (Key == 'Y' | Key == 'y');	//цикл работает, пока пользователь вводит  Y/y
		}
	}
}
