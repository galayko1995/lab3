using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace lab3Constr
{
    class QuickSort
    {
        public static void quicksort(ref int[] a, int l, int r)
        {
            int temp;
            int x = a[l + (r - l) / 2];
            //запись эквивалентна (l+r)/2, 
            //но не вызввает переполнения на больших данных
            int i = l;
            int j = r;
            //код в while обычно выносят в процедуру particle
            while (i <= j)
            {
                while (a[i] < x) i++;
                while (a[j] > x) j--;
                if (i <= j)
                {
                    temp = a[i];
                    a[i] = a[j];
                    a[j] = temp;
                    i++;
                    j--;
                }
            }
            if (i < r)
                quicksort(ref a, i, r);

            if (l < j)
                quicksort(ref a, l, j);
        }
    }
}

