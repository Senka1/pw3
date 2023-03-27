using System;

namespace PW3._6
{
    class RandomGenerator
    {
        private static readonly Random random = new Random();

        public static string GenerateRandomString(int length)
        {
            const string chars = "ABCDEFGHIJKLMNOPQRSTUVWXYZ";
            return new string(Enumerable.Repeat(chars, length)
              .Select(s => s[random.Next(s.Length)]).ToArray());
        }

        public static double GetVariance(int[] numbers)
        {
            double average = numbers.Average();
            double variance = numbers.Sum(number => Math.Pow(number - average, 2));
            variance /= numbers.Length;
            return variance;
        }

        public static double GetStandardDeviation(int[] numbers)
        {
            double variance = GetVariance(numbers);
            double standardDeviation = Math.Sqrt(variance);
            return standardDeviation;
        }

        public static double GetMedian(int[] numbers)
        {
            Array.Sort(numbers);
            int size = numbers.Length;
            int mid = size / 2;
            double median = (size % 2 != 0) ? (double)numbers[mid] : ((double)numbers[mid] + (double)numbers[mid - 1]) / 2;
            return median;
        }
    }

    internal class Program
    {
        static void Main(string[] args)
        {
            int[] numbers = new int[] { 2, 4, 4, 4, 5, 5, 7, 9 };
            Console.WriteLine("Random string: " + RandomGenerator.GenerateRandomString(5));
            Console.WriteLine("Variance: " + RandomGenerator.GetVariance(numbers));
            Console.WriteLine("Standard deviation: " + RandomGenerator.GetStandardDeviation(numbers));
            Console.WriteLine("Median: " + RandomGenerator.GetMedian(numbers));
        }
    }
}
