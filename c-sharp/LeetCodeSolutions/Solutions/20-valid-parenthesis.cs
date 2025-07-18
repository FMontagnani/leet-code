using System;
using System.Collections.Generic;
using System.Text;

namespace LeetCodeSolutions.Solutions
{
  /// <summary>
  /// LeetCode Problem 20: Valid Parentheses

  /// Problem: https://leetcode.com/problems/valid-parentheses/description/
  /// Difficulty: Easy
  /// 
  /// </summary>
  public class ValidParentheses
  {
    private static readonly Dictionary<char, char> Parenthesis = new Dictionary<char, char>
    {
        {')', '('},
        {'}', '{'},
        {']', '['},
    };

    public bool IsValid(string s)
    {
      int maxStep = s.Length - 1;
      List<char> stack = [];

      if (s.Length % 2 > 0) return false;

      if (Parenthesis.ContainsKey(s[0]))
      {
        return false;
      }

      if (Parenthesis.ContainsValue(s[maxStep]))
      {
        return false;
      }

      
      for (int i = 0; i < s.Length; i++)
      {
        char charToCheck = s[i];

        if (charToCheck == ')' | charToCheck == ']' | charToCheck == '}')
        {
          int lastStackItem = stack.Count - 1;

          if (stack.Count == 0)
          {
            return false;
          }
          if (Parenthesis[charToCheck] != stack[lastStackItem])
          {
            return false;
          }

          stack.RemoveAt(lastStackItem);
          continue;
        }
        stack.Add(s[i]);
      }
      if (stack.Count > 0) return false;
      return true;
    }
  }
}
