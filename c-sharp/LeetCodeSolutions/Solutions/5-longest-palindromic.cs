namespace LeetCodeSolutions.Solutions
{
  /// <summary>
  /// LeetCode Problem 5: Longest Palindromic Substring
  // Problem: https://leetcode.com/problems/longest-palindromic-substring/
  /// Difficulty: Medium

  // Given a string s, return the longest palindromic substring in s.
  /// </summary>
  public class LongestPalindromicSubstring
  {
    private bool IsPalindrome(string s)
    {
      int left = 0;
      int right = s.Length - 1;

      while (left < right)
      {
        if (s[left] != s[right])
        {
          return false;
        }
        left++;
        right--;
      }
      return true;
    }
    public string LongestPalindrome(string s)
    {
      string longestPalindromeSoFar = string.Empty;

      if (string.IsNullOrEmpty(s) || s.Length == 1)
      {
        return s;
      }


      for (int i = 0; i < s.Length; i++)
      {
        if (this.IsPalindrome(longestPalindromeSoFar + s[i]))
        {
          longestPalindromeSoFar += s[i];
        }
      }
      return longestPalindromeSoFar;
    }
  }
}