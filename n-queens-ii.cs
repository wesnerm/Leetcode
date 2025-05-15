// 52. N-Queens II   
// https://leetcode.com/problems/n-queens-ii
// Hard 44.1%
// 687.901913049402
// Submission: https://leetcode.com/submissions/detail/70791005/
// Runtime: 52 ms
// Your runtime beats 59.09 % of csharp submissions.

public class Solution {
        long[] cols;
        public int TotalNQueens(int n) {
                cols = new long[n];
        return Backtrack(n,0);
    }
    public int Backtrack(int n, int start)
    {
        if (!IsValid(n))
            return 0;
                if (start==n)
            return 1;
        int count = 0;
        for (int i=0; i<n; i++)
        {
            cols[start] = 1<<i;
            count += Backtrack(n, start+1);
            cols[start] = 0;
        }
                return count;
    }
    public bool IsValid(int n)
    {
        long rows = 0;
        long diag1 = 0;
        long diag2 = 0;
        for (int i=0; i<n; i++)
        {
            var c = cols[i];
                        // at most one in each col
            // if (c!=0 && (c&c-1)!=0) return false;
            if ((c & rows) != 0) return false;
            if ((c & diag1) != 0) return false;
            if ((c & diag2) != 0) return false;
                        rows |= c;
            diag1 = (diag1 | c) << 1;
            diag2 = (diag2 | c) >> 1;
        }
        return true;
    }
}
