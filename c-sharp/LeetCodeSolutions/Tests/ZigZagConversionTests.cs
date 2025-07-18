using LeetCodeSolutions.Solutions;

namespace LeetCodeSolutions.Tests
{
    /// <summary>
    /// Test cases for ZigZag Conversion problem
    /// </summary>
    public class ZigZagConversionTests
    {
        private readonly ZigZagConversion _solution;

        public ZigZagConversionTests()
        {
            _solution = new ZigZagConversion();
        }

        public void RunTests()
        {
            TestUtilities.PrintTestHeader("ZigZag Conversion");

            // Test Case 1: Example from LeetCode
            TestUtilities.RunTestCase(
                "Test Case 1",
                "LeetCode example - 3 rows",
                () => _solution.Solution("PAYPALISHIRING", 3),
                "PAHNAPLSIIGYIR",
                "s = \"PAYPALISHIRING\", numRows = 3"
            );

            // Test Case 2: Example from LeetCode - 4 rows
            TestUtilities.RunTestCase(
                "Test Case 2",
                "LeetCode example - 4 rows",
                () => _solution.Solution("PAYPALISHIRING", 4),
                "PINALSIGYAHRPI",
                "s = \"PAYPALISHIRING\", numRows = 4"
            );

            // Test Case 3: Single row (edge case)
            TestUtilities.RunTestCase(
                "Test Case 3",
                "Single row - should return original string",
                () => _solution.Solution("ABCDEFG", 1),
                "ABCDEFG",
                "s = \"ABCDEFG\", numRows = 1"
            );

            // Test Case 4: Two rows
            TestUtilities.RunTestCase(
                "Test Case 4",
                "Two rows",
                () => _solution.Solution("ABCDEF", 2),
                "ACEBDF",
                "s = \"ABCDEF\", numRows = 2"
            );

            // Test Case 5: Single character
            TestUtilities.RunTestCase(
                "Test Case 5",
                "Single character",
                () => _solution.Solution("A", 1),
                "A",
                "s = \"A\", numRows = 1"
            );

            // Test Case 6: Single character with multiple rows
            TestUtilities.RunTestCase(
                "Test Case 6",
                "Single character with multiple rows",
                () => _solution.Solution("A", 3),
                "A",
                "s = \"A\", numRows = 3"
            );

            // Test Case 7: String length equals number of rows
            TestUtilities.RunTestCase(
                "Test Case 7",
                "String length equals numRows",
                () => _solution.Solution("ABC", 3),
                "ABC",
                "s = \"ABC\", numRows = 3"
            );

            // Test Case 8: String shorter than numRows
            TestUtilities.RunTestCase(
                "Test Case 8",
                "String shorter than numRows",
                () => _solution.Solution("AB", 5),
                "AB",
                "s = \"AB\", numRows = 5"
            );

            // Test Case 9: Longer string with 3 rows
            TestUtilities.RunTestCase(
                "Test Case 9",
                "Longer string with 3 rows",
                () => _solution.Solution("ABCDEFGHIJKLMNOP", 3),
                "AEIMQBFHJNKCGLOPDH",
                "s = \"ABCDEFGHIJKLMNOP\", numRows = 3"
            );

            // Test Case 10: Five rows
            TestUtilities.RunTestCase(
                "Test Case 10",
                "Five rows",
                () => _solution.Solution("ABCDEFGHIJKLMNOP", 5),
                "AIQBHJPKCGLOFDEMN",
                "s = \"ABCDEFGHIJKLMNOP\", numRows = 5"
            );

            // Test Case 11: Repeated characters
            TestUtilities.RunTestCase(
                "Test Case 11",
                "Repeated characters",
                () => _solution.Solution("AAAAAA", 3),
                "AAAAAA",
                "s = \"AAAAAA\", numRows = 3"
            );

            // Test Case 12: Numbers and special characters
            TestUtilities.RunTestCase(
                "Test Case 12",
                "Numbers and special characters",
                () => _solution.Solution("123!@#", 2),
                "13@2!#",
                "s = \"123!@#\", numRows = 2"
            );

            // Test Case 13: Very short pattern with many rows
            TestUtilities.RunTestCase(
                "Test Case 13",
                "Very short pattern with many rows",
                () => _solution.Solution("HELLO", 10),
                "HELLO",
                "s = \"HELLO\", numRows = 10"
            );

            // Test Case 14: Exact zigzag pattern (one complete cycle)
            TestUtilities.RunTestCase(
                "Test Case 14",
                "One complete zigzag cycle",
                () => _solution.Solution("ABCDEF", 3),
                "AEBDFC",
                "s = \"ABCDEF\", numRows = 3"
            );

            // Test Case 15: Empty string (edge case)
            TestUtilities.RunTestCase(
                "Test Case 15",
                "Empty string",
                () => _solution.Solution("", 3),
                "",
                "s = \"\", numRows = 3"
            );

            TestUtilities.PrintTestFooter();
        }

        /// <summary>
        /// Helper method to visualize the zigzag pattern for debugging
        /// </summary>
        public void VisualizeZigZag(string s, int numRows)
        {
            Console.ForegroundColor = ConsoleColor.Cyan;
            Console.WriteLine($"\nVisualizing ZigZag pattern for \"{s}\" with {numRows} rows:");
            Console.ResetColor();

            if (numRows == 1)
            {
                Console.WriteLine(s);
                return;
            }

            // Create a visual representation similar to your algorithm
            var rows = new System.Text.StringBuilder[numRows];
            for (int i = 0; i < numRows; i++)
            {
                rows[i] = new System.Text.StringBuilder();
            }

            int currentRow = 0;
            bool goingDown = false;

            foreach (char c in s)
            {
                rows[currentRow].Append(c);
                
                if (currentRow == 0 || currentRow == numRows - 1)
                {
                    goingDown = !goingDown;
                }
                
                currentRow += goingDown ? 1 : -1;
            }

            for (int i = 0; i < numRows; i++)
            {
                Console.WriteLine($"Row {i}: {rows[i]}");
            }

            string result = string.Concat(rows.Select(row => row.ToString()));
            Console.WriteLine($"Result: {result}");
        }

        /// <summary>
        /// Run tests with visual output for debugging
        /// </summary>
        public void RunTestsWithVisualization()
        {
            Console.WriteLine("Running ZigZag tests with visualization...\n");

            VisualizeZigZag("PAYPALISHIRING", 3);
            VisualizeZigZag("PAYPALISHIRING", 4);
            VisualizeZigZag("ABCDEF", 3);
            VisualizeZigZag("ABCDEFGHIJKLMNOP", 5);
        }
    }
}
