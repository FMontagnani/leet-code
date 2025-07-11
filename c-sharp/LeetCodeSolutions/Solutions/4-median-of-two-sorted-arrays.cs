namespace LeetCodeSolutions.Solutions
{
    /// <summary>
    /// LeetCode Problem 4: Median of Two Sorted Arrays
    // Problem: https://leetcode.com/problems/median-of-two-sorted-arrays/
    /// Difficulty: Hard

    // Given two sorted arrays nums1 and nums2 of size m and n respectively, return the median of the two sorted arrays.
    // The overall run time complexity should be O(log (m+n)).
    /// </summary>
    public class MedianOfTwoSortedArrays
    {
        private double getMedian(int[] nums)
        {
            if (nums.Length % 2 != 0)
            {
                return nums[(int)Math.Floor((double)nums.Length / 2)];
            }

            int n1 = nums[-1 + nums.Length / 2];
            int n2 = nums[nums.Length / 2];

            return (n1 + n2) / 2;
        }

        public double FindMedianSortedArrays(int[] nums1, int[] nums2)
        {
            List<int> mergedArray = [];
            int n1Index = 0;
            int n2Index = 0;

            int maxIteration = Math.Max(nums1.Length, nums2.Length);

            for (int i = 0; i < maxIteration; i++)
            {
                mergedArray.Add(Math.Min(nums1[n1Index], nums2[n2Index]));

                if (nums1[n1Index] > nums2[n2Index])
                {
                    n2Index = Math.Min(n2Index + 1, nums2.Length - 1);
                }
                else
                {
                    n1Index = Math.Min(n1Index + 1, nums1.Length - 1);
                }
            }

            return this.getMedian([.. mergedArray]);
        }
    }
}
