namespace StrategyPattern.SortStrategies;

public class QuickSort : ISortStrategy
{
    public int[] Sort(int[] numbers)
    {
        var sortedNumbers = new int[numbers.Length];
        for (var i = 0; i < sortedNumbers.Length; i++)
        {
            sortedNumbers[i] = numbers[i];
        }

        SortArray(sortedNumbers, 0, sortedNumbers.Length - 1);
        return sortedNumbers;
    }

    private void SortArray(int[] arr, int left, int right)
    {
        if (left >= right) return;

        var pivot = Partition(arr, left, right);

        if (pivot > 1)
        {
            SortArray(arr, left, pivot - 1);
        }
        if (pivot + 1 < right)
        {
            SortArray(arr, pivot + 1, right);
        }

    }

    private static int Partition(int[] arr, int left, int right)
    {
        var pivot = arr[left];
        while (true)
        {

            while (arr[left] < pivot)
            {
                left++;
            }

            while (arr[right] > pivot)
            {
                right--;
            }

            if (left < right)
            {
                if (arr[left] == arr[right]) return right;

                (arr[left], arr[right]) = (arr[right], arr[left]);
            }
            else
            {
                return right;
            }
        }
    }
}