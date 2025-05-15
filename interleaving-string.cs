// 97. Interleaving String   
// https://leetcode.com/problems/interleaving-string
// Hard 24.4%
// 684.7962811147326
// Submission: https://leetcode.com/submissions/detail/71118503/
// Runtime: 128 ms
// Your runtime beats 7.14 % of csharp submissions.

public class Solution {
        int [,] interleave;
    public bool IsInterleave(string s1, string s2, string s3) {
        if (s1.Length+s2.Length != s3.Length) return false;
                interleave = new int[s1.Length+1,s2.Length+1];
                return IsInterleave(s1,s1.Length, s2, s2.Length,s3);        
    }
        public bool IsInterleave(string s1, int i1, string s2, int i2, string s3)
    {
        int n = i1 + i2;
        if (n==0) return true;
        //if (i1==0) return string.Compare(s3, 0, s2, 0, i2)==0;
        //if (i2==0) return string.Compare(s3, 0, s1, 0, i1)==0;
                if (interleave[i1,i2]!=0)
            return interleave[i1,i2] > 0;
        var result = i1>0 && s3[n-1]==s1[i1-1] && IsInterleave(s1,i1-1,s2,i2,s3)
            || i2>0 && s3[n-1]==s2[i2-1] && IsInterleave(s1,i1,s2,i2-1,s3);
                    interleave[i1,i2] = result ? 1 : -1;
        return result;
    }
}
