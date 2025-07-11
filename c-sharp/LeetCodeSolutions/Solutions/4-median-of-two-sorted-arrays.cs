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
                int middleIndex = nums.Length / 2;
                return nums[middleIndex];
            }
            else
            {
                int leftMiddleIndex = nums.Length / 2 - 1;
                int rightMiddleIndex = nums.Length / 2;
                int leftValue = nums[leftMiddleIndex];
                int rightValue = nums[rightMiddleIndex];
                double median = (leftValue + rightValue) / 2.0;
                
                return median;
            }
        }

        public double FindMedianSortedArrays(int[] nums1, int[] nums2)
        {
            List<int> mergedArray = new List<int>();
            int n1Index = 0;
            int n2Index = 0;

            while (n1Index < nums1.Length && n2Index < nums2.Length)
            {
                if (nums1[n1Index] <= nums2[n2Index])
                {
                    mergedArray.Add(nums1[n1Index]);
                    n1Index++;
                }
                else
                {
                    mergedArray.Add(nums2[n2Index]);
                    n2Index++;
                }
            }

            while (n1Index < nums1.Length)
            {
                mergedArray.Add(nums1[n1Index]);
                n1Index++;
            }

            while (n2Index < nums2.Length)
            {
                mergedArray.Add(nums2[n2Index]);
                n2Index++;
            }
            return this.getMedian([.. mergedArray]);
        }
    }
}
