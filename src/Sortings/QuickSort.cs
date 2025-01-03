using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sortings;
public static class SortBy
{

    public static List<int> QuickSort(List<int> numbers)
    {
        if (numbers.Count <= 2)
        {
            return numbers;
        }


        var pivot = numbers.Last();

        var smallerNumbers = new List<int>();
        var largerNumbers = new List<int>();


        foreach (var number in numbers)
        {
            if (pivot < number)
            {
                smallerNumbers.Add(number);
            }
            else if (pivot > number)
            {
                largerNumbers.Add(number);
            }
        }

        var sortedNumbers = new List<int>();

        sortedNumbers.AddRange(QuickSort(smallerNumbers));
        sortedNumbers.Add(pivot);
        sortedNumbers.AddRange(QuickSort(largerNumbers));

        return sortedNumbers;
    }
}
