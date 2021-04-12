using System;

namespace Lab_1
{
    class Program
    {
        static void Main(string[] args)
        {
			A b = new A();
			Console.WriteLine();
			Console.WriteLine("Enter 10 numbers: ");
			b.FillArray();

			Console.WriteLine();
			Console.Write("Array b4 sorting: ");
			b.Print();

			b.Sort(0, b.GetSIZE() - 1);

			Console.WriteLine();
			Console.Write("Array after sorting: ");
			b.Print();

			Console.WriteLine();
			Console.WriteLine();
			Console.WriteLine();
		}
    }
}
