namespace StrategyPattern.SortStrategies;

public class BubbleSort : ISortStrategy
{
    public int[] Sort(int[] numbers)
    {
        var sortedNumbers = new int[numbers.Length];
        for (var i = 0; i < numbers.Length; i++)
        {
            sortedNumbers[i] = numbers[i];
        }


        for (var p = 0; p <= sortedNumbers.Length - 2; p++)
        {
            for (var i = 0; i <= sortedNumbers.Length - 2; i++)
            {
                if (sortedNumbers[i] > sortedNumbers[i + 1])
                {
                    (sortedNumbers[i], sortedNumbers[i + 1]) = (sortedNumbers[i + 1], sortedNumbers[i]);
                }
            }
        }

        return sortedNumbers;
    }
}