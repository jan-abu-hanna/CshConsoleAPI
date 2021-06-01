using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;






namespace CshConsoleAPI
{
	public class AppCommands
	{
		public const string CMD_PROMPED = "\n>";
		public const string CMD_ECHO = "echo";
		public const string CMD_ADD = "add";
		public const string CMD_SUB = "sub";
		public const string CMD_MULT = "mult";
		public const string CMD_DIV = "div";

		/***
		* Echo demonstrates a command execution function.
		* the command prints the parameters it receives.
		*/
		public static bool CommandEcho(string[] parameters)
		{
			foreach (string param in parameters){
				Console.WriteLine(param);
			}
			return (true);
		}


		public static bool CommandADD(string[] parameters)
		{
			int sum = 0;
			foreach (string param in parameters)
			{
				sum += int.Parse(param);
			}
			Console.WriteLine(sum);
			return (true);
		}


		public static bool CommandSUB(string[] parameters)
		{
			int sum = 0;
			bool first = true;


			foreach (string param in parameters)
			{
				if(first)
				{
					first = false;
					sum -= int.Parse(param);
					sum *= -1;

				}
				else
				sum -= int.Parse(param);
			}
			Console.WriteLine(sum);
			return (true);
		}


		public static bool CommandMULT(string[] parameters)
		{
			int mult = 1;
			bool first = true;


			foreach (string param in parameters)
			{
				if (first)
				{
					first = false;
					mult *= int.Parse(param);
					

				}
				else
					mult *= int.Parse(param);
			}
			Console.WriteLine(mult);
			return (true);
		}

		
		public static bool CommandDIV(string[] parameters)
		{
			double div = 0;
			bool first = true;


			foreach (string param in parameters)
			{
				if (first)
				{
					first = false;
					div = double.Parse(param);


				}
				else
					div /= double.Parse(param);
			}
			Console.WriteLine(div);
			return (true);
		}


	}
}
