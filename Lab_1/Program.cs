using System;

namespace Lab_1
{
    class Program
    {
        static void Main(string[] args)
        {
			int[] arr = new[] { 6, 4, 2, 5, 1, 2, 0 };
			A b = new A(arr);
			
			Console.WriteLine();
			Console.Write("Array b4 sorting: ");
			b.Print();

			b.Sort(0, b.GetTail());

			Console.WriteLine();
			Console.Write("Array after sorting: ");
			b.Print();

			Console.WriteLine();
			Console.WriteLine();
			Console.WriteLine();
		}
    }
}
