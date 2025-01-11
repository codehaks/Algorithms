using Sortings.Algorithms;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sortings.Tests;
public class SelectionSortTests
{
    [Fact]
    public void SelectionSort_SortsNumbersCorrectly()
    {
        // Arrange
        var numbers = new List<int> { 5, 3, 8, 1, 2 };
        var expected = new List<int> { 1, 2, 3, 5, 8 };

        // Act
        var result = SelectionSort.Run(numbers);

        // Assert
        Assert.Equal(expected, result);
    }
}
