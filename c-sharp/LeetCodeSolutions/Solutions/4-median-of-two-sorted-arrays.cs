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
        private int[] getMedianIndexes(int length)
        {
            if (length % 2 == 0) {
                int right = length / 2;
                int left = right - 1;
                return [left, right];
            }
            return [length / 2];
        }

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
            List<int> mergedArray = [];

            if (nums1.Length == 0)
            {
                return this.getMedian(nums2);
            }

            if (nums2.Length == 0)
            {
                return this.getMedian(nums1);
            }

            int mergedArraySize = nums1.Length + nums2.Length;

            int[] medianIndexes = this.getMedianIndexes(mergedArraySize);

            int maxIteration = medianIndexes[medianIndexes.Length - 1];

            int n1Index = 0;
            int n2Index = 0;

            for (int i = 0; i < maxIteration + 1; i++)
            {
                int n1 = n1Index < nums1.Length ? nums1[Math.Min(n1Index, i)] : int.MaxValue;
                int n2 = n2Index < nums2.Length ? nums2[Math.Min(n2Index, i)] : int.MaxValue;

                if (n1 <= n2)
                {
                    mergedArray.Add(n1);
                    n1Index++;
                }
                else
                {
                    mergedArray.Add(n2);
                    n2Index++;
                }
            }

            if (medianIndexes.Length == 1) {
                return mergedArray.ElementAt(medianIndexes[0]);
            }

            return ((double)mergedArray.ElementAt(medianIndexes[0]) + (double)mergedArray.ElementAt(medianIndexes[1])) / 2;
        }
    }
}
