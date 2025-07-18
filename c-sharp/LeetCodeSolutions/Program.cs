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
            
            // Run Roman to Integer tests
            RomanToIntegerTests.RunTests();

            // Optional: Run additional test suites
            RomanToIntegerTests.RunEdgeCaseTests();
            RomanToIntegerTests.RunPerformanceTests();
            RomanToIntegerTests.RunVisualTests();
            
            Console.WriteLine("\n✅ All operations completed!");
            Console.WriteLine("Press any key to exit...");
            Console.ReadKey();
        }
    }
}
