using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Calc
{
	class Program
	{	
		static char[] operations = new char[] { '+', '-', '*', '/' };
		static char[] digits = "n0123456789. ".ToCharArray();				//n перед числом - обозначение отрицательного значения

		static void Main(string[] args)
		{
			Console.Write("Введите арифметическое выражение: ");
			string input = "(1 + (22 + 33) / 5 - 44 / (2 + 6) * 8) * 3";	//Console.ReadLine();
			input = "("+input+")";											//помещаем всё выражение в (), что бы условия цикла сработали для всего выражения
			Console.WriteLine(input);
			
			double result = 0.0;											//итоговый результат вычисления

			while (input.Contains('('))										//цикл работает, пока в изначальном выражении есть "("
			{
				int foundS1 = input.LastIndexOf("(");						//индекс последнией открывающей скобки "(" в выражении
				int foundS2 = input.IndexOf(")",foundS1+1);					//индекс первой закрывающей скобки ")" после foundS1 в выражении

				string expression = input.Substring(foundS1+1, foundS2-foundS1-1);	//выделяем в отдельную подстроку содержимое найденых скобок
				//Console.WriteLine(expression);

				string[] s_values = expression.Split(Program.operations);
				double[] values = new double[s_values.Length];

				for (int i = 0; i < values.Length; i++)
				{
					//Console.WriteLine(s_values[i]);
					if (s_values[i].Contains("n"))							//если s_values[i] содержит симлов отрицательного значения "n"
					{
						s_values[i]=s_values[i].Remove(0,1);				//удаляем из s_values[i] первый символ "n"
						values[i] = 0 - Convert.ToDouble(s_values[i]);		//конвертируем оставшуюся строку в double и делаем отрицательным
					}
					else values[i] = Convert.ToDouble(s_values[i]);			//иначе конвертируем s_values[i] в double
				}

				string[] operations = expression.Split(Program.digits);
				operations = operations.Where(o => o != "").ToArray();

				while (operations.Contains("*") || operations.Contains("/"))
				{
					for(int i = 0; i < operations.Length; i++)
					{
						if (operations[i] == "*") values[i] *= values[i + 1];
						if (operations[i] == "/") values[i] /= values[i + 1];
						if (operations[i]=="*" || operations[i]=="/") 
						{
							for (int j = i + 1; j < operations.Length; j++)
							{
								operations[j - 1] = operations[j];
								values[j] = values[j + 1];
							}
							if (operations[operations.Length - 1] != " ")
							{
								operations[operations.Length - 1] = " ";
								values[values.Length - 1] = 0;
							}
						}
					}
				}

				while (operations.Contains("+") || operations.Contains("-"))
				{
						if (operations[0] == "+") values[0] += values[1];
						if (operations[0] == "-") values[0] -= values[1];
						if (operations[0]=="+" || operations[0]=="-") 
						{
							for (int j = 1; j < operations.Length; j++)
							{
								operations[j - 1] = operations[j];
								values[j] = values[j + 1];
							}
							if (operations[operations.Length - 1] != " ")
							{
								operations[operations.Length - 1] = " ";
								values[values.Length - 1] = 0;
							}
						}
				}

				input = input.Remove(foundS1,foundS2-foundS1+1);			//удаляем из изначального выражения вычисленную в скобках подстроку
				if (values[0] < 0)											//если результат вычисления < 0
				{
					input = input.Insert(foundS1,"n" + Convert.ToString(-values[0]));	//вставляем в изначальное выражение, на место удаленной подстроки, вычисленный результат с добавленным символом "n"
				}
				else input = input.Insert(foundS1,Convert.ToString(values[0]));			//иначе вставляем в изначальное выражение, на место удаленной подстроки, вычисленный результат
				//Console.WriteLine(values[0]);
				//Console.WriteLine(input);
				result = values[0];
			}
			Console.WriteLine($"Ответ: {result}");
		}
	}
}
