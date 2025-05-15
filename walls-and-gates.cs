// 286. Walls and Gates   
// https://leetcode.com/problems/walls-and-gates
// Medium 43.6%
// 460.84353678250875
// Submission: https://leetcode.com/submissions/detail/68456410/
// Runtime: 252 ms
// Your runtime beats 12.12 % of csharp submissions.

public class Solution {
    public void WallsAndGates(int[,] rooms) {
        int[][] dirs = { new[]{-1,0}, new[]{1,0}, new[]{0,-1}, new[]{0,1} };
                int m=rooms.GetLength(0);
        int n=rooms.GetLength(1);
        var queue = new Queue<Point>();
                        for (int i=0; i<m; i++)
            for (int j=0; j<n; j++)
                if (rooms[i,j]==0)
                    queue.Enqueue(new Point { x=i, y= j});
                while (queue.Count > 0)
        {
            var pop = queue.Dequeue();
            int d = rooms[pop.x,pop.y]+1;
            foreach (var dir in dirs)
            {
                var pt = new Point{x=pop.x+dir[0], y=pop.y+dir[1]};
                if (pt.x<0||pt.x>=m||pt.y<0||pt.y>=n) continue;
                int d2 = rooms[pt.x, pt.y];
                if (d2<=d) continue;
                rooms[pt.x, pt.y] = d;
                queue.Enqueue(pt);
            }  
        }
    }
        class Point
    {
        public int x;
        public int y;
    }
}
