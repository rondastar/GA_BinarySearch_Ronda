using System.Diagnostics;

namespace GA_BinarySearch_Ronda
{
    internal class Program
    {
        public static void Main(string[] args)
        {
            // Test iterative binary search
            TestIterativeBinarySearch();

            // Test recursive binary search
            TestRecursiveBinarySearch();
        }

        public static void TestIterativeBinarySearch()
        {
            int[] array = { 1, 3, 5, 7, 9, 11, 13, 15, 17, 19 };
            int target = 11;

            // stop watch is used to measure time taken for the search
            Stopwatch stopwatch = Stopwatch.StartNew();
            int result = BinarySearch.IterativeBinarySearch(array, target);
            stopwatch.Stop();

            // search target, its index and the search time are printed to console
            if (result != -1)
                Console.WriteLine($"Iterative Binary Search: Element {target} found at index {result} in {stopwatch.ElapsedMilliseconds} ms");
            else
                Console.WriteLine($"Iterative Binary Search: Element {target} not found");
        }

        public static void TestRecursiveBinarySearch()
        {
            int[] array = { 2, 4, 6, 8, 10, 12, 14, 16, 18, 20 };
            int target = 14;

            // stop watch is used to measure time taken for the search
            Stopwatch stopwatch = Stopwatch.StartNew();
            int result = BinarySearch.RecursiveBinarySearch(array, target, 0, array.Length - 1);
            stopwatch.Stop();

            // search target, its index and the search time are printed to console
            if (result != -1)
                Console.WriteLine($"Recursive Binary Search: Element {target} found at index {result} in {stopwatch.ElapsedMilliseconds} ms");
            else
                Console.WriteLine($"Recursive Binary Search: Element {target} not found");
        }
    }
}
