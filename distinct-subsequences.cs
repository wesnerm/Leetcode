// 115. Distinct Subsequences   
// https://leetcode.com/problems/distinct-subsequences
// Hard 31.2%
// 855.9021270057239
// Submission: https://leetcode.com/submissions/detail/71117454/
// Runtime: 160 ms
// Your runtime beats 5.71 % of csharp submissions.

public class Solution {
    int[,] numDistinct;
        public int NumDistinct(string s, string t) {
        numDistinct=new int[s.Length+1, t.Length+1];
        return ND(s, t, s.Length, t.Length);
    }
        int ND(string s, string t, int si, int ti)
    {
        if (ti>si) return 0;
        if (si==0) return 1;
        if (ti==0) return 1;
        if (numDistinct[si,ti] > 0)
            return numDistinct[si,ti]-1;
                if (ti==si) return string.Compare(s,0,t,0,si)==0 ? 1 : 0;
                int count = ND(s,t,si-1,ti);
        if (s[si-1] == t[ti-1])
            count += ND(s,t,si-1,ti-1);
                numDistinct[si,ti] = count+1;
        return count;
    }
}
