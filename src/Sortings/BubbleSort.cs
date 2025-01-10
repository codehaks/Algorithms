using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace Sortings;
public static class BubbleSort
{
    public static List<int> Run(List<int> list)
    {
        int n = list.Count;
        bool swapped = true;

        while (swapped)
        {
            swapped = false;
            for (int i = 0; i < n - 1; i++)
            {
                if (list[i] > list[i + 1])
                {
                    // Swap adjacent elements
                    int temp = list[i];
                    list[i] = list[i + 1];
                    list[i + 1] = temp;

                    swapped = true;
                }
            }
            n--; // Reduce the range of the next pass
        }

        return list;
    }
}
