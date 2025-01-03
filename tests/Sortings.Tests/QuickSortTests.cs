namespace Sortings.Tests;

public class QuickSortTests
{
    [Fact]
    public void QuickSort_SortsNumbersCorrectly()
    {
        // Arrange
        var numbers = new List<int> { 5, 3, 8, 1, 2 };
        var expected = new List<int> { 1, 2, 3, 5, 8 };

        // Act
        var result = SortBy.QuickSort(numbers);

        // Assert
        Assert.Equal(expected, result);
    }

    [Fact]
    public void QuickSort_Sorts_duplicate_numbers_NumbersCorrectly()
    {
        // Arrange
        var numbers = new List<int> { 5,2, 8, 1, 2 };
        var expected = new List<int> { 1, 2, 2, 5, 8 };

        // Act
        var result = SortBy.QuickSort(numbers);

        // Assert
        Assert.Equal(expected, result);
    }

    [Fact]
    public void QuickSort_ReturnsEmptyListForEmptyInput()
    {
        // Arrange
        var numbers = new List<int>();
        var expected = new List<int>();

        // Act
        var result = SortBy.QuickSort(numbers);

        // Assert
        Assert.Equal(expected, result);
    }

    [Fact]
    public void QuickSort_ReturnsSingleElementListForSingleInput()
    {
        // Arrange
        var numbers = new List<int> { 42 };
        var expected = new List<int> { 42 };

        // Act
        var result = SortBy.QuickSort(numbers);

        // Assert
        Assert.Equal(expected, result);
    }
}
