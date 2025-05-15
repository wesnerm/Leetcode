// 392. Is Subsequence   
// https://leetcode.com/problems/is-subsequence
// Medium 44.3%
// 414.716173157993
// Submission: https://leetcode.com/submissions/detail/73104693/
// Runtime: 149 ms
// Your runtime beats 49.15 % of csharp submissions.

public class Solution {
    public bool IsSubsequence(string s, string t) {
        int i=0; 
        for (int j=0; i<s.Length && j<t.Length; j++)
            if (s[i]==t[j]) 
            i++;
        return i==s.Length;
    }
}
