using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace lab3Constr
{
    {
        {
            int marker = start;
            for (int i = start; i <= end; i++)
            {
                if (array[i] <= array[end])
                {
                    int temp = array[marker]; // swap
                    array[marker] = array[i];
                    array[i] = temp;
                    marker += 1;
                }
            }
            return marker - 1;
        }

        {
            if (start >= end)
            {
                return;
            }
    }
}

