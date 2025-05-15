// 387. First Unique Character in a String   
// https://leetcode.com/problems/first-unique-character-in-a-string
// Easy 46.4%
// 955.1464190783068
// Submission: https://leetcode.com/submissions/detail/105463772/
// Runtime: 135 ms
// Your runtime beats 80.22 % of csharp submissions.

public class Solution {
    public int FirstUniqChar(string s) {
        int[] seen = new int[128];
                for (int i=s.Length-1; i>=0; i--)
            seen[s[i]]++;
                for (int i=0; i<s.Length; i++)
            if (seen[s[i]] == 1)
                return i;
                return -1;
    }
}
