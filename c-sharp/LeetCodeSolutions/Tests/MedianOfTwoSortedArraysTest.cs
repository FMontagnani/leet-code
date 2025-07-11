// Problem: https://leetcode.com/problems/median-of-two-sorted-arrays/
using System;
using LeetCodeSolutions.Solutions;

namespace LeetCodeSolutions.Tests
{
    public class MedianOfTwoSortedArraysTest
    {
        private static readonly MedianOfTwoSortedArrays solution = new MedianOfTwoSortedArrays();
        
        public static void RunTests()
        {
            TestUtilities.PrintTestHeader("FindMedianSortedArrays");

            // Test case 1: Basic example from LeetCode
            TestUtilities.RunTestCase(
                "Test Case 1",
                "Basic case - odd total length",
                () => solution.FindMedianSortedArrays([1, 3], [2]),
                2.0,
                "nums1 = [1, 3], nums2 = [2]"
            );

            // Test case 2: Even total length
            TestUtilities.RunTestCase(
                "Test Case 2",
                "Basic case - even total length",
                () => solution.FindMedianSortedArrays([1, 2], [3, 4]),
                2.5,
                "nums1 = [1, 2], nums2 = [3, 4]"
            );

            // Test case 3: One empty array
            // TestUtilities.RunTestCase(
            //     "Test Case 3",
            //     "One empty array",
            //     () => solution.FindMedianSortedArrays([], [1]),
            //     1.0,
            //     "nums1 = [], nums2 = [1]"
            // );

            // Test case 4: Both arrays have same elements
            TestUtilities.RunTestCase(
                "Test Case 4",
                "All same elements",
                () => solution.FindMedianSortedArrays([1, 1], [1, 1]),
                1.0,
                "nums1 = [1, 1], nums2 = [1, 1]"
            );

            // Test case 5: Arrays with different sizes
            TestUtilities.RunTestCase(
                "Test Case 5",
                "Different sizes",
                () => solution.FindMedianSortedArrays([1, 3, 5], [2, 4, 6, 7, 8]),
                4.5,
                "nums1 = [1, 3, 5], nums2 = [2, 4, 6, 7, 8]"
            );

            // Test case 6: One array much larger
            TestUtilities.RunTestCase(
                "Test Case 6",
                "One array much larger",
                () => solution.FindMedianSortedArrays([1], [2, 3, 4, 5, 6]),
                3.5,
                "nums1 = [1], nums2 = [2, 3, 4, 5, 6]"
            );

            // Test case 7: Negative numbers
            TestUtilities.RunTestCase(
                "Test Case 7",
                "With negative numbers",
                () => solution.FindMedianSortedArrays([-2, -1], [0, 1]),
                -0.5,
                "nums1 = [-2, -1], nums2 = [0, 1]"
            );

            // Test case 8: Single element arrays
            TestUtilities.RunTestCase(
                "Test Case 8",
                "Single element arrays",
                () => solution.FindMedianSortedArrays([5], [3]),
                4.0,
                "nums1 = [5], nums2 = [3]"
            );

            // Test case 9: Arrays with duplicates
            TestUtilities.RunTestCase(
                "Test Case 9",
                "Arrays with duplicates",
                () => solution.FindMedianSortedArrays([1, 2, 2], [2, 3, 4]),
                2.0,
                "nums1 = [1, 2, 2], nums2 = [2, 3, 4]"
            );

            // Test case 10: Large gap between arrays
            TestUtilities.RunTestCase(
                "Test Case 10",
                "Large gap between arrays",
                () => solution.FindMedianSortedArrays([1, 2], [100, 200]),
                51.0,
                "nums1 = [1, 2], nums2 = [100, 200]"
            );
            
            TestUtilities.PrintTestFooter();
        }
    }
}
