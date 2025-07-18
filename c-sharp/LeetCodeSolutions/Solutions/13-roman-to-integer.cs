using System;
using System.Collections.Generic;
using System.Text;

namespace LeetCodeSolutions.Solutions
{
    /// <summary>
    /// LeetCode Problem 13: Roman to Integer

    /// Problem: https://leetcode.com/problems/roman-to-integer/description/
    /// Difficulty: Easy
    /// 

    /// </summary>
    public class RomanToInteger
    {
        private static readonly Dictionary<char, int> romanToIntMap = new Dictionary<char, int>
        {
            {'I', 1},
            {'V', 5},
            {'X', 10},
            {'L', 50},
            {'C', 100},
            {'D', 500},
            {'M', 1000}
        };

        public int Solution(string s)
        {
            int total = 0;
            int LAST_ITEM = s.Length -1;
            
            if (s.Length == 1)
            {
               return romanToIntMap[s[0]];
            }

            for (int i = 0; i < s.Length; i++)
            {
                if (romanToIntMap[s[i]] < romanToIntMap[s[Math.Min(i + 1, LAST_ITEM)]])
                {
                    total -= romanToIntMap[s[i]];
                    continue;
                }
                total += romanToIntMap[s[i]];
            }
        
            return total;
        }
    }
}
