// 424. Longest Repeating Character Replacement   
// https://leetcode.com/problems/longest-repeating-character-replacement
// Medium 41.7%
// 316.46176430954785
// Submission: https://leetcode.com/submissions/detail/101881780/
// Runtime: 1888 ms
// Your runtime beats 0.00 % of csharp submissions.

public class Solution {
    public int CharacterReplacement(string s, int k) {
                int max = 0;
        for (int i=0; i<s.Length; i++)
        {
            int used = 0;
            int j=i+1;
            for (; j<s.Length; j++)
            {
                if (s[j] == s[i]) continue;
                if (used == k) break;
                used++;
            }
            int left = i + (s.Length-j);
            max = Math.Max(max, j-i + Math.Min(left, k-used));            
        }
        return max;
    }
}
