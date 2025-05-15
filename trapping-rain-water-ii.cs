// 407. Trapping Rain Water II   
// https://leetcode.com/problems/trapping-rain-water-ii
// Hard 36.3%
// 347.6197762091299
// Submission: https://leetcode.com/submissions/detail/76300862/
// Runtime: 435 ms
// Your runtime beats 22.22 % of csharp submissions.

public class Solution {
        public class Cell : IComparable<Cell>
    {
        public int r;
        public int c;
        public int h;
                public Cell(int r, int c, int h)
        {
            this.r=r;
            this.c=c;
            this.h=h;
        }
                public int CompareTo(Cell cell)
        {
            int cmp = h - cell.h;
            if (cmp != 0) return cmp;
            cmp = r - cell.r;
            if (cmp != 0) return cmp;
            return c - cell.c;
        }
    }
            public int TrapRainWater(int[,] heightMap) {
        int rows = heightMap.GetLength(0);
        int cols = heightMap.GetLength(1);
                var pq = new SortedSet<Cell>();
        var visited = new bool[rows,cols];
        for (int i=0; i<rows; i++)
        for (int j=0; j<cols; j++)
        if (i==0 || j==0 || i==rows-1 || j==cols-1)
        {
            pq.Add(new Cell(i,j,heightMap[i,j]));
            visited[i,j] = true;
        }
        int[] dir = new int [] { 0, 1, 0, -1, 0 };
        int water = 0;
        while(pq.Count>0)
        {
            var cell = pq.Min;
            pq.Remove(cell);
            for (int d=0; d<4; d++)
            {
                int r=cell.r + dir[d];
                int c=cell.c + dir[d+1];
                if (r<0 || c<0 || r>=rows || c>=cols || visited[r,c]) continue;
                visited[r,c]= true;
                water += Math.Max(0, cell.h - heightMap[r,c]);
                pq.Add(new Cell(r,c,Math.Max(cell.h, heightMap[r,c])));
            }
        }
                return water;
    }
}
