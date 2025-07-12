using LeetCodeSolutions.Solutions;

namespace LeetCodeSolutions.Tests
{
    /// <summary>
    /// Test cases for Two Sum problem
    /// </summary>
    public class TwoSumTests
    {
        private readonly TwoSum _twoSum;

        public TwoSumTests()
        {
            _twoSum = new TwoSum();
        }

        public void RunTests()
        {
            TestUtilities.PrintTestHeader("Two Sum");
            
            // Test Case 1
            TestUtilities.RunTestCase(
                "Test Case 1",
                "Basic example from LeetCode",
                () => _twoSum.TwoSumSolution([2, 7, 11, 15], 9),
                new int[] { 0, 1 },
                "nums = [2, 7, 11, 15], target = 9"
            );
            
            // Test Case 2
            TestUtilities.RunTestCase(
                "Test Case 2",
                "Target in middle of array",
                () => _twoSum.TwoSumSolution([3, 2, 4], 6),
                new int[] { 1, 2 },
                "nums = [3, 2, 4], target = 6"
            );
            
            // Test Case 3
            TestUtilities.RunTestCase(
                "Test Case 3",
                "Same elements",
                () => _twoSum.TwoSumSolution([3, 3], 6),
                new int[] { 0, 1 },
                "nums = [3, 3], target = 6"
            );
            
            TestUtilities.PrintTestFooter();
        }
    }
}
