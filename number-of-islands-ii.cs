// 305. Number of Islands II   
// https://leetcode.com/problems/number-of-islands-ii
// Hard 38.5%
// 428.37438866733345
// Submission: https://leetcode.com/submissions/detail/69551016/
// Runtime: 696 ms
// Your runtime beats 40.00 % of csharp submissions.

public class Solution {
            int m;
        int n;
        int[] ds;
        bool[] land;
        int islands = 0;
        public IList<int> NumIslands2(int m, int n, int[,] positions)
        {
            this.m = m;
            this.n = n;
                        ds = new int[Index2(m + 1, 0)];
            land = new bool[Index2(m + 1, 0)];
            for (int i = 0; i < ds.Length; i++)
                ds[i] = i;
            var list = new List<int>();
            int plen = positions.GetLength(0);
            for (int i = 0; i < plen; i++)
            {
                int r = positions[i, 0];
                int c = positions[i, 1];
                // Add Positions            
                if (!A(r,c))
                {
                    if (!Valid(r,c)) throw new Exception();
                                        land[Index(r, c)] = true;
                    islands++;
                        UnionAdjacent(r, c, 1, 0);
                    UnionAdjacent(r, c, -1, 0);
                    UnionAdjacent(r, c, 0, 1);
                    UnionAdjacent(r, c, 0, -1);
                }
                list.Add(islands);
            }
            return list;
        }
        public void UnionAdjacent(int r, int c, int dr, int dc)
        {
            int r2 = r + dr;
            int c2 = c + dc;
            if (A(r2, c2) && Union(Index(r, c), Index(r2, c2)))
                islands--;
        }
        public bool A(int r, int c)
        {
            return Valid(r,c) && land[Index(r, c)];
        }
                public bool Valid(int r, int c)
        {
            if (r < 0 || r >= m || c < 0 || c >= n) return false;
            return true;
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
            if (r != a)
                ds[a] = r = Find(r);
            return r;
        }
        public int Index(int r, int c)
        {
            if (!Valid(r,c)) throw new Exception();
            return r * (n+1) + c;
        }
                public int Index2(int r, int c)
        {
            return r * (n + 1) + c;
        }
    }
