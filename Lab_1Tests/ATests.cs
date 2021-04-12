using Microsoft.VisualStudio.TestTools.UnitTesting;
using Lab_1;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab_1.Tests
{
    [TestClass()]
    public class QuickSortTests
    {
        [TestMethod()]
        public void GetSortedArrEl()
        {   
            int[] test = new[] { 6, 4, 2, 5, 1, 2, 0 };
            QuickSort b = new QuickSort(test);

            for (int i = 0; i < test.Length; i++)
            {
                int actual = b.GetSortedArrEl(i);
                int expected = test[i];
                Assert.AreEqual(expected, actual);
            }
        }

        [TestMethod()]
        public void SortTest()
        {
            int[] test = new[] { 6, 4, 2, 5, 1, 2, 0 };
            QuickSort b = new QuickSort(test);
            b.Sort(0, test.Length - 1);
            int[] expected = new int[] { 0, 1, 2, 2, 4, 5, 6 };

            for (int i = 0; i < test.Length; i++)
            {
                int actual = b.GetSortedArrEl(i);
                Assert.AreEqual(expected[i], actual);
            }

        }
    }
}