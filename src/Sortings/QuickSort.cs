﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sortings;
public static class SortBy
{

    public static List<int> QuickSort(List<int> numbers)
    {
        if (numbers.Count == 0)
        {
            return numbers;
        }
        var pivot = numbers.Last();

        var smallerNumbers = new List<int>();
        var equalNumbers = new List<int>();
        var largerNumbers = new List<int>();

        foreach (var number in numbers)
        {
            if (number < pivot)
            {
                smallerNumbers.Add(number);
            }else if (number == pivot)
            {
                equalNumbers.Add(number);
            }
            else if (number > pivot)
            {
                largerNumbers.Add(number);
            }
        }

        var tempNumbers = new List<int>();

        tempNumbers.AddRange(QuickSort(smallerNumbers));
        tempNumbers.AddRange(equalNumbers);
        tempNumbers.AddRange(QuickSort(largerNumbers));

        return tempNumbers;
    }
}
