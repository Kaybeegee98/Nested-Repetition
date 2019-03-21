using System;

namespace Task_1_B
{
	class Program
	{
		public static void Main(string[] args)
		{
			Console.Write("Please Enter Your Name: ");
			String name = Console.ReadLine();
			Console.Write("Please Enter Number of Repetition(s) Down: ");
			string num = Console.ReadLine();
			Console.Write("Please Enter Number of Repetition(s) Across: ");
			string num2 = Console.ReadLine();
			int rep = int.Parse(num);
			int rep2 = int.Parse(num2);
			int counter = 0;
			
			while (counter < rep) {
				counter += 1;
				int counter2 = 0;
				while (counter2 < rep2) {
					counter2 += 1;
					Console.Write(name);
				}
				Console.WriteLine();
			}
			Console.WriteLine("Goodbye");
			Console.ReadLine();
		}
	}
}