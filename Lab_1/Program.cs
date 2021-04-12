using System;

namespace Lab_1
{
    class Program
    {

		static void Main(string[] args)
        {
			int[] arr = new[] { 6, 4, 2, 5, 1, 2, 0 };
			QuickSort b = new QuickSort(arr);

			Console.Write("Array b4 sorting: ");
			Print(arr);
			b.Sort(0, arr.Length - 1);
			Console.Write("Array after sorting: ");
			GetArr(arr, b);
			Print(arr);
		}

		static void Print(int[] _array)
		{
			string _string = "";
			for (int i = 0; i < _array.Length; i++)
			{
				if (i == 0) _string += ("[" + _array[i] + ",");
				if ((i != 0) && (i != _array.Length - 1)) _string += (" " + _array[i] + ",");
				if (i == _array.Length - 1) _string += (" " + _array[i] + "]");
			}

			Console.WriteLine(_string);
		}

		static void GetArr(int[] _array, QuickSort _sorted)
		{
			for (int i = 0; i < _array.Length; i++)
			{
				_array[i] = _sorted.GetSortedArrEl(i);
			}
		}

	}
}
