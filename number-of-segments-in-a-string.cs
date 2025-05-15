// 434. Number of Segments in a String   
// https://leetcode.com/problems/number-of-segments-in-a-string
// Easy 36.9%
// 319.144073290616
// Submission: https://leetcode.com/submissions/detail/101885499/
// Runtime: 118 ms
// Your runtime beats 26.09 % of csharp submissions.

public class Solution {
    public int CountSegments(string s) {
                int segments = 0;
        bool space = true;
        foreach(var ch in s)
        {
            if (char.IsWhiteSpace(ch))
            {
                space = true;
            }
            else if (space == true)
            {
                segments++;
                space = false;
            }
        }
                return segments;
    }
}
