using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab_1
{
    class A
    {
		const int SIZE = 10;

		int[] arr = new int[SIZE];

		public int GetSIZE()
		{
			return SIZE;
		}

		public void FillArray()
		{
			for (int i = 0; i < SIZE; i++)
			{
				arr[i] = Convert.ToInt32(Console.ReadLine());
			}
		}

		public void Print()
		{
			for (int i = 0; i < SIZE; i++)
			{
				Console.Write("" + this.arr[i] + ", ");
			}
		}

		public void Sort(int head, int tail)
		{
			int i = head, j = tail;
			int pivot = this.arr[tail];

			do
			{
				while (this.arr[i] < pivot) i++;
				while (this.arr[j] > pivot) j--;

				if (i <= j)
				{
					int temp;
					temp = this.arr[i];
					this.arr[i] = this.arr[j];
					this.arr[j] = temp;
					i++;
					j--;
				}

			} while (i <= j);

			if (head < j) this.Sort(head, j);
			if (tail > i) this.Sort(i, tail);
		}
	}
}
