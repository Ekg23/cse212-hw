/// <summary>
/// These 3 functions will (in different ways) calculate the standard
/// deviation from a list of numbers.  The standard deviation
/// is defined as the square root of the variance.  The variance is 
/// defined as the average of the squared differences from the mean.
/// </summary>
public static class StandardDeviation
{
    public static void Run()
    {
        var numbers = new[] { 600, 470, 170, 430, 300 };
        Console.WriteLine(StandardDeviation1(numbers)); // Should be 147.322 
        Console.WriteLine(StandardDeviation2(numbers)); // Should be 147.322 
        Console.WriteLine(StandardDeviation3(numbers)); // Should be 147.322 
    }

    // O(n) time complexity, O(1) space complexity
    private static double StandardDeviation1(int[] numbers)
    {
        var total = 0.0;
        var count = 0;
        foreach (var number in numbers)
        {
            total += number;
            count += 1;
        }

        var avg = total / count;
        var sumSquaredDifferences = 0.0;
        foreach (var number in numbers)
        {
            sumSquaredDifferences += Math.Pow(number - avg, 2);
        }

        var variance = sumSquaredDifferences / count;
        return Math.Sqrt(variance);
    }

    // O(n^2) time complexity, O(1) space complexity
    private static double StandardDeviation2(int[] numbers)
    {
        var sumSquaredDifferences = 0.0;
        var countNumbers = 0;
        foreach (var number in numbers)
        {
            var total = 0;
            var count = 0;
            foreach (var value in numbers)
            {
                total += value;
                count += 1;
            }

            var avg = total / count;
            sumSquaredDifferences += Math.Pow(number - avg, 2);
            countNumbers += 1;
        }

        var variance = sumSquaredDifferences / countNumbers;
        return Math.Sqrt(variance);
    }


    // O(n) time complexity, O(1) space complexity
    private static double StandardDeviation3(int[] numbers)
    {
        var count = numbers.Length;
        var avg = (double)numbers.Sum() / count;
        var sumSquaredDifferences = 0.0;
        foreach (var number in numbers)
        {
            sumSquaredDifferences += Math.Pow(number - avg, 2);
        }

        var variance = sumSquaredDifferences / count;
        return Math.Sqrt(variance);
    }
}

// Big O Notationn from best big O to worst big O:
// O(1) < O(logn) < O(n) < O(nlogn) < O(n2) < O(2n)