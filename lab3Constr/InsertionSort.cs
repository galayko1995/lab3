using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace lab3Constr
{
    class InsertionSort
    {
        public static void insertionSort(ref int[] m, int a, int b)
        {
            int t;
            int i, j;
            for (i = a + 1; i < b; i++)
            {
                t = m[i];
                for (j = i - 1; j >= a && m[j] > t; j--)
                    m[j + 1] = m[j];
                m[j + 1] = t;
            }
        }

        private int rank(int val, int[] arr)
        {
            return rank(val, arr, 0, arr.Length - 1);
        }

        private static int rank(int val, int[] arr, int lo, int hi)
        {
            if (lo > hi)
                return -1;

            int mid = lo + (hi - lo) / 2;

            if (val < arr[mid])
            {
                return rank(val, arr, lo, mid - 1);
            }
            else if (val > arr[mid])
            {
                return rank(val, arr, mid + 1, hi);
            }
            else
            {
                return mid;
            }
        }

    }
}
