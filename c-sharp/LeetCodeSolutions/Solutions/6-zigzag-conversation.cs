using System;
using System.Collections.Generic;
using System.Text;

namespace LeetCodeSolutions.Solutions
{
    /// <summary>
    /// LeetCode Problem 6: ZigZag Conversion
    /// Problem: https://leetcode.com/problems/zigzag-conversion/description/
    /// Difficulty: Medium
    /// 
    /// Optimized solution using hash function to map character positions
    /// and linked lists to avoid matrix creation
    /// </summary>
    public class ZigZagConversion
    {
        private class CharNode
        {
            public char Character { get; set; }
            public CharNode? Next { get; set; }
            
            public CharNode(char c)
            {
                Character = c;
                Next = null;
            }
        }
        
        /// <summary>
        /// Hash function to calculate the row for a given character position
        /// </summary>
        /// <param name="index">Character position in original string</param>
        /// <param name="numRows">Number of rows in zigzag pattern</param>
        /// <returns>Row number (0-based)</returns>
        private int GetRowFromIndex(int index, int numRows)
        {
            if (numRows == 1) return 0;
            
            // The zigzag pattern repeats every (2 * numRows - 2) characters
            int cycleLength = 2 * numRows - 2;
            int positionInCycle = index % cycleLength;
            
            // If we're in the first half of the cycle, we're going down
            if (positionInCycle < numRows)
            {
                return positionInCycle;
            }
            // If we're in the second half, we're going up
            else
            {
                return cycleLength - positionInCycle;
            }
        }
        
        public string Solution(string s, int numRows)
        {
            // Edge cases
            if (string.IsNullOrEmpty(s) || numRows <= 1 || s.Length <= numRows)
            {
                return s;
            }
            
            CharNode[] rowHeads = new CharNode[numRows];
            CharNode[] rowTails = new CharNode[numRows];
            
            Console.ForegroundColor = ConsoleColor.Cyan;
            Console.WriteLine($"Processing string: \"{s}\" with {numRows} rows");
            Console.ResetColor();
            
            // Single pass through the string
            for (int i = 0; i < s.Length; i++)
            {
                // Use hash function to determine row
                int targetRow = GetRowFromIndex(i, numRows);
                
                // Create new node for this character
                CharNode newNode = new CharNode(s[i]);
                
                // Add to the appropriate row's linked list
                if (rowHeads[targetRow] == null)
                {
                    // First character in this row
                    rowHeads[targetRow] = newNode;
                    rowTails[targetRow] = newNode;
                }
                else
                {
                    // Append to existing row
                    rowTails[targetRow].Next = newNode;
                    rowTails[targetRow] = newNode;
                }
            }
            
            // Build result by traversing each row's linked list
            StringBuilder result = new StringBuilder();
            
            for (int row = 0; row < numRows; row++)
            {
                StringBuilder rowContent = new StringBuilder();
                CharNode current = rowHeads[row];
                
                while (current != null)
                {
                    result.Append(current.Character);
                    rowContent.Append(current.Character);
                    current = current.Next;
                }
            }
            
            string finalResult = result.ToString();
            
            return finalResult;
        }
        
        /// <summary>
        /// Alternative solution with even more optimized hash function
        /// Uses direct mathematical calculation without linked lists
        /// </summary>
        public string OptimizedSolution(string s, int numRows)
        {
            if (string.IsNullOrEmpty(s) || numRows <= 1 || s.Length <= numRows)
            {
                return s;
            }
            
            StringBuilder result = new StringBuilder();
            int cycleLength = 2 * numRows - 2;
            
            // Process each row
            for (int row = 0; row < numRows; row++)
            {
                // For each row, calculate which characters belong to it
                for (int i = row; i < s.Length; i += cycleLength)
                {
                    // Add the main character for this position
                    result.Append(s[i]);
                    
                    // For middle rows, add the diagonal character
                    if (row > 0 && row < numRows - 1)
                    {
                        int diagonalIndex = i + cycleLength - 2 * row;
                        if (diagonalIndex < s.Length)
                        {
                            result.Append(s[diagonalIndex]);
                        }
                    }
                }
            }
            
            return result.ToString();
        }
    }
}
