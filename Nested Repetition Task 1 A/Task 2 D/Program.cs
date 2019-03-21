using System;

namespace Task_2_D
{
	class Program
	{
		public static void Main(string[] args)
		{
			Console.Write("Please Enter Your Name Here: ");
			string name = Console.ReadLine();
			Console.Write("Please Enter a Number of Lines: ");
			string input = Console.ReadLine();
			int num = int.Parse(input);
			int counter = 0;
				while(counter < num) {
					int counter2 = counter;
					counter += 1;
					
					while(counter2 >= 0) {
						counter2 -=1;
						Console.Write(name);
					}
					Console.WriteLine();
			}
			Console.WriteLine("Goodbye");
			Console.ReadLine();
		}
	}
}