// 132. Palindrome Partitioning II   
// https://leetcode.com/problems/palindrome-partitioning-ii
// Hard 23.9%
// 533.7229985848385
// Submission: https://leetcode.com/submissions/detail/70686386/
// Runtime: 148 ms
// Your runtime beats 16.67 % of csharp submissions.

public class Solution {
    public int MinCut(string s) {
        bool[,] p = MakePalindromes(s);
        int n = s.Length;
        int[] v = new int[n];
                v[n-1] = 0;
        for (int i=n-2; i>=0; i--)
        {
            if (p[i,n-1]) continue;
            int cuts = n-1 - i;
            for (int j=i; j+1<n; j++)
            {
                if (!p[i,j]) continue;
                cuts = Math.Min(cuts, 1 + v[j+1] );
            }
            v[i] = cuts;
        }
                return v[0];
    }
        bool[,] MakePalindromes(string s)
    {
        int n = s.Length;
        var p = new bool[n,n];
        for (int i=0; i<n; i++)
            p[i,i] = true;
                    for (int d=1; d<n; d++)
        for (int i=0,j=d; j<n; i++,j++)
            p[i,j] = s[i]==s[j] && (d==1 || p[i+1,j-1]); 
        return p;            
    }
}
