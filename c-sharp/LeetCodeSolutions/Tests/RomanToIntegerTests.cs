using System;
using LeetCodeSolutions.Solutions;

namespace LeetCodeSolutions.Tests
{
    /// <summary>
    /// Test cases for Roman to Integer problem (LeetCode #13)
    /// </summary>
    public class RomanToIntegerTests
    {
        private static readonly RomanToInteger solution = new RomanToInteger();
        
        public static void RunTests()
        {
            TestUtilities.PrintTestHeader("Roman to Integer");

            // Test Case 1: Basic single characters
            TestUtilities.RunTestCase(
                "Test Case 1",
                "Single character - I",
                () => solution.Solution("I"),
                1,
                "s = \"I\""
            );

            TestUtilities.RunTestCase(
                "Test Case 2",
                "Single character - V",
                () => solution.Solution("V"),
                5,
                "s = \"V\""
            );

            TestUtilities.RunTestCase(
                "Test Case 3",
                "Single character - X",
                () => solution.Solution("X"),
                10,
                "s = \"X\""
            );

            TestUtilities.RunTestCase(
                "Test Case 4",
                "Single character - L",
                () => solution.Solution("L"),
                50,
                "s = \"L\""
            );

            TestUtilities.RunTestCase(
                "Test Case 5",
                "Single character - C",
                () => solution.Solution("C"),
                100,
                "s = \"C\""
            );

            TestUtilities.RunTestCase(
                "Test Case 6",
                "Single character - D",
                () => solution.Solution("D"),
                500,
                "s = \"D\""
            );

            TestUtilities.RunTestCase(
                "Test Case 7",
                "Single character - M",
                () => solution.Solution("M"),
                1000,
                "s = \"M\""
            );

            // Test Case 8-10: Basic addition cases
            TestUtilities.RunTestCase(
                "Test Case 8",
                "Simple addition - II",
                () => solution.Solution("II"),
                2,
                "s = \"II\""
            );

            TestUtilities.RunTestCase(
                "Test Case 9",
                "Simple addition - III",
                () => solution.Solution("III"),
                3,
                "s = \"III\""
            );

            TestUtilities.RunTestCase(
                "Test Case 10",
                "Simple addition - VI",
                () => solution.Solution("VI"),
                6,
                "s = \"VI\""
            );

            // Test Case 11-16: Subtraction cases
            TestUtilities.RunTestCase(
                "Test Case 11",
                "Subtraction - IV (4)",
                () => solution.Solution("IV"),
                4,
                "s = \"IV\""
            );

            TestUtilities.RunTestCase(
                "Test Case 12",
                "Subtraction - IX (9)",
                () => solution.Solution("IX"),
                9,
                "s = \"IX\""
            );

            TestUtilities.RunTestCase(
                "Test Case 13",
                "Subtraction - XL (40)",
                () => solution.Solution("XL"),
                40,
                "s = \"XL\""
            );

            TestUtilities.RunTestCase(
                "Test Case 14",
                "Subtraction - XC (90)",
                () => solution.Solution("XC"),
                90,
                "s = \"XC\""
            );

            TestUtilities.RunTestCase(
                "Test Case 15",
                "Subtraction - CD (400)",
                () => solution.Solution("CD"),
                400,
                "s = \"CD\""
            );

            TestUtilities.RunTestCase(
                "Test Case 16",
                "Subtraction - CM (900)",
                () => solution.Solution("CM"),
                900,
                "s = \"CM\""
            );

            // Test Case 17-22: LeetCode examples and common numbers
            TestUtilities.RunTestCase(
                "Test Case 17",
                "LeetCode example - III",
                () => solution.Solution("III"),
                3,
                "s = \"III\""
            );

            TestUtilities.RunTestCase(
                "Test Case 18",
                "LeetCode example - LVIII (58)",
                () => solution.Solution("LVIII"),
                58,
                "s = \"LVIII\" (L=50, V=5, III=3)"
            );

            TestUtilities.RunTestCase(
                "Test Case 19",
                "LeetCode example - MCMXC (1994)",
                () => solution.Solution("MCMXC"),
                1990,
                "s = \"MCMXC\" (M=1000, CM=900, XC=90)"
            );

            TestUtilities.RunTestCase(
                "Test Case 20",
                "Complex number - MCDXLIV (1444)",
                () => solution.Solution("MCDXLIV"),
                1444,
                "s = \"MCDXLIV\" (M=1000, CD=400, XL=40, IV=4)"
            );

            TestUtilities.RunTestCase(
                "Test Case 21",
                "Year 1994 - MCMXCIV",
                () => solution.Solution("MCMXCIV"),
                1994,
                "s = \"MCMXCIV\" (M=1000, CM=900, XC=90, IV=4)"
            );

            TestUtilities.RunTestCase(
                "Test Case 22",
                "Maximum value - MMMCMXCIX (3999)",
                () => solution.Solution("MMMCMXCIX"),
                3999,
                "s = \"MMMCMXCIX\" (MMM=3000, CM=900, XC=90, IX=9)"
            );

            // Test Case 23-28: Edge cases and tricky patterns
            TestUtilities.RunTestCase(
                "Test Case 23",
                "Mixed pattern - MCMLIV (1954)",
                () => solution.Solution("MCMLIV"),
                1954,
                "s = \"MCMLIV\" (M=1000, CM=900, L=50, IV=4)"
            );

            TestUtilities.RunTestCase(
                "Test Case 24",
                "Multiple subtractions - CDXLIV (444)",
                () => solution.Solution("CDXLIV"),
                444,
                "s = \"CDXLIV\" (CD=400, XL=40, IV=4)"
            );

            TestUtilities.RunTestCase(
                "Test Case 25",
                "All digits - MCDXLIV (1444)",
                () => solution.Solution("MCDXLIV"),
                1444,
                "s = \"MCDXLIV\""
            );

            TestUtilities.RunTestCase(
                "Test Case 26",
                "Consecutive additions - VII (7)",
                () => solution.Solution("VII"),
                7,
                "s = \"VII\" (V=5, II=2)"
            );

            TestUtilities.RunTestCase(
                "Test Case 27",
                "Large number - MMMDCCCLXXXVIII (3888)",
                () => solution.Solution("MMMDCCCLXXXVIII"),
                3888,
                "s = \"MMMDCCCLXXXVIII\""
            );

            TestUtilities.RunTestCase(
                "Test Case 28",
                "Mixed operations - DCXXI (621)",
                () => solution.Solution("DCXXI"),
                621,
                "s = \"DCXXI\" (D=500, C=100, XX=20, I=1)"
            );

            TestUtilities.PrintTestFooter();
        }

        /// <summary>
        /// Additional edge case tests
        /// </summary>
        public static void RunEdgeCaseTests()
        {
            TestUtilities.PrintTestHeader("Roman to Integer - Edge Cases");

            // Test potential boundary conditions
            Console.ForegroundColor = ConsoleColor.Yellow;
            Console.WriteLine("Testing edge cases and boundary conditions:");
            Console.ResetColor();

            // Edge case 1: Minimum value
            TestUtilities.RunTestCase(
                "Edge Case 1",
                "Minimum value",
                () => solution.Solution("I"),
                1,
                "Minimum Roman numeral"
            );

            // Edge case 2: Maximum standard value
            TestUtilities.RunTestCase(
                "Edge Case 2",
                "Maximum standard value",
                () => solution.Solution("MMMCMXCIX"),
                3999,
                "Maximum standard Roman numeral"
            );

            // Edge case 3: All subtraction pairs
            string[] subtractionPairs = { "IV", "IX", "XL", "XC", "CD", "CM" };
            int[] expectedValues = { 4, 9, 40, 90, 400, 900 };

            for (int i = 0; i < subtractionPairs.Length; i++)
            {
                TestUtilities.RunTestCase(
                    $"Subtraction Test {i + 1}",
                    $"Subtraction pair {subtractionPairs[i]}",
                    () => solution.Solution(subtractionPairs[i]),
                    expectedValues[i],
                    $"s = \"{subtractionPairs[i]}\""
                );
            }

            TestUtilities.PrintTestFooter();
        }

        /// <summary>
        /// Performance and stress tests
        /// </summary>
        public static void RunPerformanceTests()
        {
            TestUtilities.PrintTestHeader("Roman to Integer - Performance Tests");

            Console.ForegroundColor = ConsoleColor.Yellow;
            Console.WriteLine("Running performance tests...");
            Console.ResetColor();

            // Test with various string lengths
            string[] performanceTests = {
                "I",                    // Length 1
                "IV",                   // Length 2
                "LVIII",               // Length 5
                "MCMXCIV",            // Length 7
                "MMMCMXCIX",          // Length 9
                "MMMDCCCLXXXVIII"     // Length 15
            };

            foreach (string test in performanceTests)
            {
                var startTime = DateTime.Now;
                int result = solution.Solution(test);
                var endTime = DateTime.Now;
                var duration = endTime - startTime;

                Console.WriteLine($"Input: {test,-15} | Result: {result,-4} | Time: {duration.TotalMilliseconds:F3}ms");
            }

            TestUtilities.PrintTestFooter();
        }

        /// <summary>
        /// Visual breakdown of Roman numeral conversion
        /// </summary>
        public static void RunVisualTests()
        {
            TestUtilities.PrintTestHeader("Roman to Integer - Visual Breakdown");

            string[] visualTests = { "MCMXCIV", "LVIII", "CDXLIV" };

            foreach (string test in visualTests)
            {
                Console.ForegroundColor = ConsoleColor.Cyan;
                Console.WriteLine($"\nBreaking down: {test}");
                Console.ResetColor();

                int result = solution.Solution(test);
                
                Console.WriteLine($"Character by character analysis:");
                for (int i = 0; i < test.Length; i++)
                {
                    char current = test[i];
                    bool isSubtraction = i < test.Length - 1 && 
                        GetRomanValue(current) < GetRomanValue(test[i + 1]);
                    
                    string operation = isSubtraction ? "subtract" : "add";
                    string color = isSubtraction ? "Red" : "Green";
                    
                    if (isSubtraction)
                    {
                        Console.ForegroundColor = ConsoleColor.Red;
                    }
                    else
                    {
                        Console.ForegroundColor = ConsoleColor.Green;
                    }
                    
                    Console.WriteLine($"  {current} = {GetRomanValue(current)} ({operation})");
                    Console.ResetColor();
                }
                
                Console.ForegroundColor = ConsoleColor.Yellow;
                Console.WriteLine($"Final result: {result}");
                Console.ResetColor();
            }

            TestUtilities.PrintTestFooter();
        }

        /// <summary>
        /// Helper method to get Roman numeral value
        /// </summary>
        private static int GetRomanValue(char c)
        {
            return c switch
            {
                'I' => 1,
                'V' => 5,
                'X' => 10,
                'L' => 50,
                'C' => 100,
                'D' => 500,
                'M' => 1000,
                _ => 0
            };
        }
    }
}
