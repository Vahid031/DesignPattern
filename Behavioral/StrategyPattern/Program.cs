

using StrategyPattern;
using StrategyPattern.SortStrategies;

Console.WriteLine("Strategy pattern sample");
Console.WriteLine("++++++++++++++++++++++++++++++++++++++++++");
var numbers = new int[] { 15, 7, 13, 1, 8, 26, 4, 11 };

Console.WriteLine("Quick sort");
var quickSortStrategy = new SortedNumber(new QuickSort());
quickSortStrategy.Sort(numbers);



Console.WriteLine("Merge sort");
var mergeSortStrategy = new SortedNumber(new MergeSort());
mergeSortStrategy.Sort(numbers);



Console.WriteLine("Bubble sort");
var bubbleSortStrategy = new SortedNumber(new BubbleSort());
bubbleSortStrategy.Sort(numbers);

