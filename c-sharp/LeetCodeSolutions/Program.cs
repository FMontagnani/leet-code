using LeetCodeSolutions.Solutions;
using LeetCodeSolutions.Tests;

namespace LeetCodeSolutions
{
    class Program
    {
        static void Main(string[] args)
        {
            // Console.WriteLine("🚀 LeetCode Solutions in C#");
            // Console.WriteLine("===========================");
            
            // Example: Run a solution
            // var twoSum = new TwoSum();
            // var result = twoSum.TwoSumSolution(new int[] {2, 7, 11, 15}, 9);
            // Console.WriteLine($"Two Sum Result: [{string.Join(", ", result)}]");
            
            Console.WriteLine("\n🧪 Running Tests...");
            Console.WriteLine("==================");

            // Run tests
            // var twoSumTests = new TwoSumTests();
            // twoSumTests.RunTests();
            
            MedianOfTwoSortedArraysTest.RunTests();
            
            Console.WriteLine("\n✅ All operations completed!");
            Console.WriteLine("Press any key to exit...");
            Console.ReadKey();
        }
    }
}
