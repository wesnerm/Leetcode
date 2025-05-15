// 51. N-Queens   
// https://leetcode.com/problems/n-queens
// Hard 30.3%
// 733.3172026594135
// Submission: https://leetcode.com/submissions/detail/70791901/
// Runtime: 424 ms
// Your runtime beats 66.67 % of csharp submissions.

public class Solution {
    long[] cols;
    public IList<IList<string>> SolveNQueens(int n) {
        var list = new List<IList<string>>();
        cols = new long[n];
        Backtrack(list, n,0);
        return list;
    }
    public int Backtrack(List<IList<string>> list, int n, int start)
    {
        if (!IsValid(n))
            return 0;
                if (start==n)
        {
            list.Add(CurrentBoard(n));
            return 1;
        }
        int count = 0;
        for (int i=0; i<n; i++)
        {
            cols[start] = 1<<i;
            count += Backtrack(list, n, start+1);
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
    public List<string> CurrentBoard(int n)
    {
        var list = new List<string>();
        foreach(var c in cols)
        {
            var sb = new StringBuilder();
            for (int i=0; i<n; i++)
                sb.Append( (c&1<<i) == 0 ? '.' : 'Q');
            list.Add(sb.ToString());
        }
        return list;
    }
                }
