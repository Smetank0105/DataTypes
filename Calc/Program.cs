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
			string input = "(1 + (22 + 33) / 5 + 44 / (2 + 6) * 8) * 3";//"(1 + (22 + 33) / 5 - 44 / (2 + 6) * 8) * 3";
			input = "("+input+")";
			Console.WriteLine(input);

			while (input.Contains('('))
			{
				int foundS1 = input.LastIndexOf("(");
				int foundS2 = input.IndexOf(")",foundS1+1);

				string expression = input.Substring(foundS1+1, foundS2-foundS1-1);
				//Console.WriteLine(expression);

				string[] s_values = expression.Split(Program.operations);
				double[] values = new double[s_values.Length];
				for (int i = 0; i < values.Length; i++)
				{
					values[i] = Convert.ToDouble(s_values[i]);
				}
				Console.WriteLine();
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
				input = input.Remove(foundS1,foundS2-foundS1+1);
				input = input.Insert(foundS1,Convert.ToString(values[0]));
				//Console.WriteLine($"Ответ: { values[0]}");
				Console.WriteLine(input);
			}
		}
	}
}
