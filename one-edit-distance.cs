// 161. One Edit Distance   
// https://leetcode.com/problems/one-edit-distance
// Medium 31.0%
// 583.0379188821041
// Submission: https://leetcode.com/submissions/detail/70568410/
// Runtime: 128 ms
// Your runtime beats 27.27 % of csharp submissions.

public class Solution {
    public bool IsOneEditDistance(string s, string t) {
        if (s.Length > t.Length)
            return IsOneEditDistance(t,s);
                if (s.Length == t.Length)
        {
            int edits = 0;
            for (int i=0; i<s.Length; i++)
                if (s[i] != t[i] && edits++ != 0)
                    return false;
            return edits == 1;
        }
                if (t.Length - s.Length > 1)
            return false;
                int left = 0;
        int right = 0;
        while (left<s.Length && s[left] == t[left])
            left++;
                    while (right<s.Length && s[s.Length-right-1] == t[t.Length-right-1])
            right++;
                    return (left + right >= s.Length);
    }
}
