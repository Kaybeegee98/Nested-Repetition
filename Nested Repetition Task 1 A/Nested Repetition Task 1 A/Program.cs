using System;

namespace Nested_Repetition_Task_1_A
{
	class Program
	{
		public static void Main(string[] args)
		{
			Console.Write("Please Enter Your Name: ");
			String name = Console.ReadLine();
			int counter = 0;
			
			while (counter <10) {
				counter += 1;
				int counter2 = 0;
				
				while (counter2 < 10) {
					counter2 += 1;
					Console.Write(name);
				}
				Console.WriteLine();
			}
			Console.WriteLine("Goodbye");
			Console.ReadKey();
		}
	}
}