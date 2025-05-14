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
		static char[] digits = "0123456789. ".ToCharArray();
		static void Main(string[] args)
		{

			Console.Write("Введите арифметическое выражение: ");
			string expression = Console.ReadLine();
			string[] s_values = expression.Split(Program.operations);
			double[] values = new double[s_values.Length];
			for (int i = 0; i < values.Length; i++)
			{
				//Console.Write(values[i]+"\t");
				values[i] = Convert.ToDouble(s_values[i]);
			}
			Console.WriteLine();
			string[] operations = expression.Split(Program.digits);
			operations = operations.Where(o => o != "").ToArray();
			//for(int i = 0; i < operations.Length; i++)
			//{
			//	Console.Write(operations[i]+"\t");
			//}
			//Console.WriteLine();

			#region Simple
			/* double a = Convert.ToDouble(values[0]);
				double b = Convert.ToDouble(values[1]);
				char current_operation = expression[expression.IndexOfAny(Program.operations)];
				Console.Write(expression);
				switch (current_operation)
				{
					case '+': Console.WriteLine($" = {a + b}"); break;
					case '-': Console.WriteLine($" = {a - b}"); break;
					case '*': Console.WriteLine($" = {a * b}"); break;
					case '/': Console.WriteLine($" = {a / b}"); break;
					default: Console.WriteLine("Error: No operation"); break;
				}*/
			#endregion

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
			//for(int i = 0; i < values.Length; i++)
			//{
			//	Console.Write(values[i]+"\t");
			//}
			//Console.WriteLine();

			//for(int i = 0; i < operations.Length; i++)
			//{
			//	Console.Write(operations[i] + "\t");
			//}
			//Console.WriteLine();

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
			//for (int i = 0; i < values.Length; i++)
			//{
			//	Console.Write(values[i] + "\t");
			//}
			//Console.WriteLine();
			//for (int i = 0; i < operations.Length; i++)
			//{
			//	Console.Write(operations[i] + "\t");
			//}
			Console.WriteLine($"Ответ: { values[0]}");
		}
	}
}
