namespace LeetCodeSolutions.Solutions
{
    /// <summary>
    /// LeetCode Problem 1: Two Sum
    /// Difficulty: Easy
    /// 
    /// Given an array of integers nums and an integer target, return indices of the two numbers
    /// such that they add up to target.
    /// 
    /// Time Complexity: O(n)
    /// Space Complexity: O(n)
    /// </summary>
    public class TwoSum
    {
        public int[] TwoSumSolution(int[] nums, int target)
        {
            // Dictionary to store number and its index
            Dictionary<int, int> numMap = new Dictionary<int, int>();
            
            for (int i = 0; i < nums.Length; i++)
            {
                int complement = target - nums[i];
                
                // Check if complement exists in the dictionary
                if (numMap.ContainsKey(complement))
                {
                    return new int[] { numMap[complement], i };
                }
                
                // Store the current number and its index
                if (!numMap.ContainsKey(nums[i]))
                {
                    numMap[nums[i]] = i;
                }
            }
            
            // Return empty array if no solution found
            return new int[] { };
        }
    }
}
