// 378. Kth Smallest Element in a Sorted Matrix   
// https://leetcode.com/problems/kth-smallest-element-in-a-sorted-matrix
// Medium 44.1%
// 610.4842674303881
// Submission: https://leetcode.com/submissions/detail/73436372/
// Runtime: 239 ms
// Your runtime beats 57.58 % of csharp submissions.

public class Solution {
    public int KthSmallest2(int[,] matrix, int k) {
        int m = matrix.GetLength(0);
        int n = matrix.GetLength(1);
                var pq = new SortedSet<Data>(new Comparer {matrix=matrix});
        pq.Add(new Data{ row=0, col=0 });
        while (pq.Count>0)
        {
            var pop = pq.Min;
            pq.Remove(pop);
                        var val = matrix[pop.row, pop.col];
            if (--k == 0) return val;
                        if (pop.row==0 && pop.col+1<n) pq.Add(new Data{row=0, col= pop.col+1});
            if (++pop.row < m) pq.Add(pop);
        }
         // klogn for this
         // klogk if we start from topright cell and move down (and also move right if on the first row)
        return -1;
    }
    public int KthSmallest(int[,] matrix, int k) 
    {
        int m = matrix.GetLength(0);
        int n = matrix.GetLength(1);
        if (k>m*n || k<1)
            return -1;
        int rlen = m;
        int [] mi = new int[m];
        int [] rows = new int[m];
        for (int i=0; i<m; i++)
            rows[i] = i;
        while (true)
        {
            int min = int.MaxValue;
            int argmin = -1;
            int argi = -1;
                        int d = Math.Max(k/rlen-1, 0);
            for (int i=0; i<rlen; i++)
            {
                int ri = rows[i];
                int c = Math.Min(mi[ri]+d, n-1);
                int v = matrix[ri,c];
                if (v<min) { min = v; argmin=ri; argi=i; }
            }
            Console.WriteLine("k={0}, d={1}, argmin={2}, min={3}", k, d, argmin, min);
                                    int remove = Math.Min(d+1, n-mi[argmin]);
            k -= remove;
            mi[argmin] += remove;
            if (k==0)
                return min;
            if (mi[argmin] >= n)
                rows[argi] = rows[--rlen];
        }
    }
    public class Comparer : IComparer<Data>
    {
        public int[,] matrix;
        public int Compare(Data self, Data other)
        {
            int cmp = matrix[self.row, self.col] - matrix[other.row,other.col];
            if (cmp != 0) return cmp;
            cmp = self.row - other.row;
            if (cmp != 0) return cmp;
            cmp = self.col - other.col;
            return cmp;
        }
    }
        public class Data
    {
        public int row;
        public int col;
    }
}
