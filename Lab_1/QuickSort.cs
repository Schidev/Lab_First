using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab_1
{
    public class QuickSort
	{
		private static int[] _array;

		public QuickSort(int[] array)
		{
			_array = new int[array.Length];
			for (int i = 0; i < array.Length; i++)
			{
				//_array[i] = Convert.ToInt32(Console.ReadLine());
				_array[i] = array[i];
			}
		}

		public int GetSortedArrEl(int i)
		{
			return _array[i];
		}

		public void Sort(int head, int tail)
		{
			int i = head, j = tail;
			int pivot = _array[tail];

			do
			{
				while (_array[i] < pivot) i++;
				while (_array[j] > pivot) j--;

				if (i <= j)
				{
					int temp;
					temp = _array[i];
					_array[i] = _array[j];
					_array[j] = temp;
					i++;
					j--;
				}

			} while (i <= j);

			if (head < j) this.Sort(head, j);
			if (tail > i) this.Sort(i, tail);
		}
	}

}
