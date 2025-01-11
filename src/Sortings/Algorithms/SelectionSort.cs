using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sortings.Algorithms;
public static class SelectionSort
{
    public static List<int> Run(List<int> list)
    {
        for (int j = 0; j < list.Count - 1; j++) // Outer loop for each position
        {
            int minIndex = j; // Assume the first unsorted element is the minimum

            // Find the index of the smallest element in the unsorted part
            for (int i = j + 1; i < list.Count; i++)
            {
                if (list[i] < list[minIndex])
                {
                    minIndex = i;
                }
            }

            // Swap the minimum element with the first unsorted element
            if (minIndex != j)
            {
                int temp = list[j];
                list[j] = list[minIndex];
                list[minIndex] = temp;
            }
        }

        return list;
    }
}
