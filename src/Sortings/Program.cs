using Sortings;

Console.WriteLine("Quick Sort Demo");

var random = new Random();

var numbers = Enumerable.Range(1, 100).OrderBy(x => random.Next()).ToList();
var sortedNumbers = SortBy.QuickSort(numbers);

for (int i = 0; i < numbers.Count; i++)
{
    Console.WriteLine($"[{i + 1}] --- {numbers[i]:000} --> {sortedNumbers[i]:000}");
}