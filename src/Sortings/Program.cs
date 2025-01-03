using Sortings;

Console.WriteLine("Quick Sort Demo");

var random = new Random();

var numbers = new List<int>();

for (int i = 1; i <= 100; i++)
{
    var num = random.Next(1, 100);
    numbers.Add(num);
}

var sortedNumbers = SortBy.QuickSort(numbers);

for (int i = 0; i < numbers.Count; i++)
{
    Console.WriteLine($"[{i + 1}] --- {numbers[i]:000} --> {sortedNumbers[i]:000}");
}