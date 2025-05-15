// 68. Text Justification   
// https://leetcode.com/problems/text-justification
// Hard 18.7%
// 646.1257479297991
// Submission: https://leetcode.com/submissions/detail/71388648/
// Runtime: 505 ms
// Your runtime beats 18.18 % of csharp submissions.

public class Solution {
    public IList<string> FullJustify(string[] words, int maxWidth) 
    {
        return BreakTest(words, maxWidth).ToList();
    }
        public IEnumerable<string> BreakTest(string[] words, int maxWidth)
    {
        var sb = new StringBuilder();
        int start = 0;
        while (start<words.Length)
        {
            // First add the word
            sb.Clear();
            sb.Append(words[start++]);
                        // Find the edge
            int rowlen = sb.Length;
            int i=start;
            for (; i<words.Length; i++)
            {
                int newlen = rowlen + words[i].Length + 1; 
                if (newlen > maxWidth)
                    break;
                rowlen = newlen;
            }
            int gap = maxWidth-rowlen;
            for (; start<i; start++)
            {
                int slots = i-start;
                // ceiling division for leftiness -- if we want evenness, then don't use
                int spaces = (i==words.Length ? 0 : (gap+slots-1)/slots); 
                sb.Append(' ', 1+spaces); // Add the necessary space separately
                sb.Append(words[start]);
                gap -= spaces;
            }
                        sb.Append(' ', Math.Max(0, maxWidth-sb.Length));
            yield return sb.ToString();
        }
    }
    }
