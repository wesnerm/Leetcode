// 317. Shortest Distance from All Buildings   
// https://leetcode.com/problems/shortest-distance-from-all-buildings
// Hard 33.7%
// 391.2878536338661
// Submission: https://leetcode.com/submissions/detail/69493916/
// Runtime: 172 ms
// Your runtime beats 87.50 % of csharp submissions.

public class Solution {
    public int ShortestDistance(int[,] grid) {
        int rows=grid.GetLength(0);
        int cols=grid.GetLength(1);
        var dist = new int[rows,cols];
        int mindist = int.MaxValue;
        var total = new int[rows,cols];
        int [] delta = new [] {0, 1, 0, -1, 0};
                var q = new Queue<Point>();
                int walk=0;
        for (int r=0; r<rows; r++)
            for (int c=0; c<cols; c++)
                if (grid[r,c] == 1)
                {
                    mindist = int.MaxValue;
                    Array.Clear(dist, 0, dist.Length);
                    q.Enqueue(new Point{r=r,c=c});
                    while (q.Count>0)
                    {
                        var p = q.Dequeue();
                        for (int d = 0; d < 4; d++)
                        {
                            var t = new Point { r = p.r + delta[d], c = p.c + delta[d + 1] };
                            if (t.r >= 0 && t.c >= 0 && t.r < rows && t.c < cols && grid[t.r, t.c] == walk)
                            {
                                grid[t.r, t.c]--;
                                dist[t.r, t.c] = dist[p.r, p.c] + 1;
                                total[t.r, t.c] += dist[t.r, t.c];
                                q.Enqueue(t);
                                mindist = Math.Min(mindist, total[t.r, t.c]);
                            }
                        }
                    }
                    walk--;
                }
                        return mindist==int.MaxValue ? -1 : mindist;
    }
        public class Point
    {
        public int r;
        public int c;
    }
    }
