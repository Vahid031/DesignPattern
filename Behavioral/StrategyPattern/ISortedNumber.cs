namespace StrategyPattern;

public class SortedNumber
{
    private readonly ISortStrategy _sortStrategy;

    public SortedNumber(ISortStrategy sortStrategy)
    {
        _sortStrategy = sortStrategy;
    }

    public void Sort(int[] numbers)
    {
        Console.WriteLine("++++++++++++++++++++++++++++++++++++++++++");
        Console.WriteLine("Unsorted numbers");
        Print(numbers);

        var sortedNumbers = _sortStrategy.Sort(numbers);

        Console.WriteLine("sorted numbers");
        Print(sortedNumbers);

        Console.WriteLine("++++++++++++++++++++++++++++++++++++++++++");
    }

    private static void Print(int[] numbers)
    {
        foreach (var number in numbers)
        {
            Console.WriteLine(number);
        }
    }
}