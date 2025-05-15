// 323. Number of Connected Components in an Undirected Graph   
// https://leetcode.com/problems/number-of-connected-components-in-an-undirected-graph
// Medium 47.7%
// 269.93760921305136
// Submission: https://leetcode.com/submissions/detail/69708740/
// Runtime: 194 ms
// Your runtime beats 29.41 % of csharp submissions.

public class Solution {
     int [] ds;
     public int CountComponents(int n, int[,] edges) {
        int len = edges.GetLength(0);
        ds = new int[n];
        Init();
                for (int i=0; i<len; i++)
        {
            int a = edges[i,0];
            int b = edges[i,1];
            Union(a,b);
        }
                int count = 0;
        for (int i=0; i<n; i++)
        {
            if (ds[i] == i)
                count++;
        }
                return count;
    }
    public void Init()
    {
        for (int i = 0; i<ds.Length; i++)
            ds[i] = i;
    }
        public bool Union(int a, int b)
    {
        int ra = Find(a);
        int rb = Find(b);
        if (ra == rb)
            return false;
        if (ra < rb)
            ds[rb] = ra;
        else
            ds[ra] = rb;
        return true;
    }
    public int Find(int a)
    {
        int r = ds[a];
                if (r==-1)
            r = ds[a] = a;
        if (r != a)
            ds[a] = r = Find(r);
                return r;
    }
}
