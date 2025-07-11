using System;

namespace LeetCodeSolutions.Tests
{
    /// <summary>
    /// Utility class for common test operations
    /// </summary>
    public static class TestUtilities
    {
        /// <summary>
        /// Runs a test case with colored console output
        /// </summary>
        /// <param name="testName">Name of the test</param>
        /// <param name="description">Description of what the test does</param>
        /// <param name="testAction">Function that returns the actual result</param>
        /// <param name="expected">Expected result</param>
        /// <param name="inputDescription">Description of the input parameters</param>
        public static void RunTestCase<T>(string testName, string description, Func<T> testAction, T expected, string inputDescription = "")
        {
            try
            {
                T result = testAction();
                bool passed = IsEqual(result, expected);
                
                // Color the test description
                Console.ForegroundColor = ConsoleColor.Cyan;
                Console.WriteLine($"Test: {testName} - {description}");
                Console.ResetColor();
                
                // Color the input if provided
                if (!string.IsNullOrEmpty(inputDescription))
                {
                    Console.ForegroundColor = ConsoleColor.Yellow;
                    Console.WriteLine($"Input: {inputDescription}");
                    Console.ResetColor();
                }
                
                // Color expected and result
                Console.ForegroundColor = ConsoleColor.White;
                Console.WriteLine($"Expected: {expected}, Got: {result}");
                Console.ResetColor();
                
                // Color the result based on pass/fail
                if (passed)
                {
                    Console.ForegroundColor = ConsoleColor.Green;
                    Console.WriteLine($"Result: ✓ PASS");
                }
                else
                {
                    Console.ForegroundColor = ConsoleColor.Red;
                    Console.WriteLine($"Result: ✗ FAIL");
                }
                Console.ResetColor();
                Console.WriteLine();
            }
            catch (Exception ex)
            {
                Console.ForegroundColor = ConsoleColor.Red;
                Console.WriteLine($"Test: {testName} - {description}");
                Console.WriteLine($"Result: ✗ ERROR - {ex.Message}");
                Console.ResetColor();
                Console.WriteLine();
            }
        }
        
        /// <summary>
        /// Prints a colored header for test suites
        /// </summary>
        /// <param name="title">Title of the test suite</param>
        public static void PrintTestHeader(string title)
        {
            Console.ForegroundColor = ConsoleColor.Magenta;
            Console.WriteLine("=".PadRight(50, '='));
            Console.WriteLine($"Running tests for {title}...");
            Console.WriteLine("=".PadRight(50, '='));
            Console.ResetColor();
            Console.WriteLine();
        }
        
        /// <summary>
        /// Prints a colored footer for test completion
        /// </summary>
        public static void PrintTestFooter()
        {
            Console.ForegroundColor = ConsoleColor.Green;
            Console.WriteLine("=".PadRight(50, '='));
            Console.WriteLine("All tests completed!");
            Console.WriteLine("=".PadRight(50, '='));
            Console.ResetColor();
        }
        
        /// <summary>
        /// Generic equality comparison
        /// </summary>
        private static bool IsEqual<T>(T actual, T expected)
        {
            if (actual is double actualDouble && expected is double expectedDouble)
            {
                return Math.Abs(actualDouble - expectedDouble) < 0.0001;
            }
            
            if (actual is float actualFloat && expected is float expectedFloat)
            {
                return Math.Abs(actualFloat - expectedFloat) < 0.0001f;
            }
            
            return actual?.Equals(expected) ?? expected == null;
        }
    }
}