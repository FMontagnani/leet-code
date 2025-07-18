using System;
using LeetCodeSolutions.Solutions;

namespace LeetCodeSolutions.Tests
{
    /// <summary>
    /// Test cases for Valid Parentheses problem (LeetCode #20)
    /// </summary>
    public class ValidParenthesesTests
    {
        private static readonly ValidParentheses solution = new ValidParentheses();
        
        public static void RunTests()
        {
            TestUtilities.PrintTestHeader("Valid Parentheses");

            // Test case 1: Basic valid cases
            TestUtilities.RunTestCase(
                "Test Case 1",
                "Simple valid parentheses",
                () => solution.IsValid("()"),
                true,
                "s = \"()\""
            );

            // Test case 2: Multiple types valid
            TestUtilities.RunTestCase(
                "Test Case 2",
                "Multiple valid parentheses types",
                () => solution.IsValid("()[]{}"),
                true,
                "s = \"()[]{}\""
            );

            // Test case 3: Nested valid parentheses
            TestUtilities.RunTestCase(
                "Test Case 3",
                "Nested valid parentheses",
                () => solution.IsValid("([{}])"),
                true,
                "s = \"([{}])\""
            );

            // Test case 4: Complex nested valid
            TestUtilities.RunTestCase(
                "Test Case 4",
                "Complex nested valid",
                () => solution.IsValid("{[()]}"),
                true,
                "s = \"{[()]}\""
            );

            // Test case 5: Simple invalid - wrong closing
            TestUtilities.RunTestCase(
                "Test Case 5",
                "Invalid - wrong closing bracket",
                () => solution.IsValid("(]"),
                false,
                "s = \"(]\""
            );

            // Test case 6: Invalid - mismatched order
            TestUtilities.RunTestCase(
                "Test Case 6",
                "Invalid - mismatched order",
                () => solution.IsValid("([)]"),
                false,
                "s = \"([)]\""
            );

            // Test case 7: Invalid - starts with closing
            TestUtilities.RunTestCase(
                "Test Case 7",
                "Invalid - starts with closing bracket",
                () => solution.IsValid(")"),
                false,
                "s = \")\""
            );

            // Test case 8: Invalid - ends with opening
            TestUtilities.RunTestCase(
                "Test Case 8",
                "Invalid - ends with opening bracket",
                () => solution.IsValid("("),
                false,
                "s = \"(\""
            );

            // Test case 9: Invalid - odd length
            TestUtilities.RunTestCase(
                "Test Case 9",
                "Invalid - odd length string",
                () => solution.IsValid("((("),
                false,
                "s = \"(((\""
            );

            // Test case 10: Edge case - empty string
            TestUtilities.RunTestCase(
                "Test Case 10",
                "Edge case - empty string",
                () => solution.IsValid(""),
                true,
                "s = \"\""
            );

            // Test case 11: Multiple same type valid
            TestUtilities.RunTestCase(
                "Test Case 11",
                "Multiple same type valid",
                () => solution.IsValid("((()))"),
                true,
                "s = \"((()))\""
            );

            // Test case 12: Multiple same type invalid
            TestUtilities.RunTestCase(
                "Test Case 12",
                "Multiple same type invalid",
                () => solution.IsValid("((())"),
                false,
                "s = \"((())\""
            );

            // Test case 13: Complex valid pattern
            TestUtilities.RunTestCase(
                "Test Case 13",
                "Complex valid pattern",
                () => solution.IsValid("(){}[]"),
                true,
                "s = \"(){}[]\""
            );

            // Test case 14: Complex invalid pattern
            TestUtilities.RunTestCase(
                "Test Case 14",
                "Complex invalid pattern",
                () => solution.IsValid("([{})]"),
                false,
                "s = \"([{})]\"" 
            );

            // Test case 15: Large valid nested
            TestUtilities.RunTestCase(
                "Test Case 15",
                "Large valid nested structure",
                () => solution.IsValid("((((()))))[[[[[]]]]]{{{{{}}}}}}"),
                true,
                "s = \"((((()))))[[[[[]]]]]{{{{{}}}}}}}\""
            );

            // Test case 16: Only opening brackets
            TestUtilities.RunTestCase(
                "Test Case 16",
                "Only opening brackets",
                () => solution.IsValid("((("),
                false,
                "s = \"(((\""
            );

            // Test case 17: Only closing brackets
            TestUtilities.RunTestCase(
                "Test Case 17",
                "Only closing brackets",
                () => solution.IsValid(")))"),
                false,
                "s = \")))\""
            );

            // Test case 18: Mixed valid with all types
            TestUtilities.RunTestCase(
                "Test Case 18",
                "Mixed valid with all bracket types",
                () => solution.IsValid("({[]})"),
                true,
                "s = \"({[]})\""
            );

            // Test case 19: Single character valid
            TestUtilities.RunTestCase(
                "Test Case 19",
                "Single bracket pair - curly",
                () => solution.IsValid("{}"),
                true,
                "s = \"{}\""
            );

            // Test case 20: Single character valid - square
            TestUtilities.RunTestCase(
                "Test Case 20",
                "Single bracket pair - square",
                () => solution.IsValid("[]"),
                true,
                "s = \"[]\""
            );

            TestUtilities.PrintTestFooter();
        }

        /// <summary>
        /// Additional method to test edge cases and performance
        /// </summary>
        public static void RunEdgeCaseTests()
        {
            TestUtilities.PrintTestHeader("Valid Parentheses - Edge Cases");

            // Test potential bugs in the current implementation
            Console.ForegroundColor = ConsoleColor.Yellow;
            Console.WriteLine("Testing potential issues in current implementation:");
            Console.ResetColor();

            // Bug test 1: Empty string handling
            try
            {
                bool result = solution.IsValid("");
                Console.WriteLine($"Empty string test: {result} (should be true)");
            }
            catch (Exception ex)
            {
                Console.ForegroundColor = ConsoleColor.Red;
                Console.WriteLine($"Empty string test failed: {ex.Message}");
                Console.ResetColor();
            }

            // Bug test 2: Single character
            try
            {
                bool result = solution.IsValid("(");
                Console.WriteLine($"Single opening bracket test: {result} (should be false)");
            }
            catch (Exception ex)
            {
                Console.ForegroundColor = ConsoleColor.Red;
                Console.WriteLine($"Single bracket test failed: {ex.Message}");
                Console.ResetColor();
            }

            // Bug test 3: Stack empty when trying to pop
            try
            {
                bool result = solution.IsValid(")(");
                Console.WriteLine($"Closing then opening test: {result} (should be false)");
            }
            catch (Exception ex)
            {
                Console.ForegroundColor = ConsoleColor.Red;
                Console.WriteLine($"Stack empty test failed: {ex.Message}");
                Console.ResetColor();
            }

            TestUtilities.PrintTestFooter();
        }

        /// <summary>
        /// Visual test to show bracket matching process
        /// </summary>
        public static void RunVisualTests()
        {
            TestUtilities.PrintTestHeader("Valid Parentheses - Visual Tests");

            string[] testCases = {
                "()",
                "([{}])",
                "([)]",
                "(((",
                ")))",
                "({[]})"
            };

            foreach (string testCase in testCases)
            {
                Console.ForegroundColor = ConsoleColor.Cyan;
                Console.WriteLine($"\nTesting: \"{testCase}\"");
                Console.ResetColor();
                
                bool result = solution.IsValid(testCase);
                
                if (result)
                {
                    Console.ForegroundColor = ConsoleColor.Green;
                    Console.WriteLine("✓ VALID");
                }
                else
                {
                    Console.ForegroundColor = ConsoleColor.Red;
                    Console.WriteLine("✗ INVALID");
                }
                Console.ResetColor();
            }

            TestUtilities.PrintTestFooter();
        }
    }
}