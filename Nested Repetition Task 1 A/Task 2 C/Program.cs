using System;

namespace Task_2_C
{
	class Program
	{
		public static void Main(string[] args)
		{
			Console.Write("Please Enter Your Name Here: ");
			string name = Console.ReadLine();
			int counter = 0;
				while(counter < 5) {
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