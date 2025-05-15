// 542. 01 Matrix   
// https://leetcode.com/problems/01-matrix
// Medium 33.0%
// 366.26271898828907
// Submission: https://leetcode.com/submissions/detail/111586838/
// Runtime: 455 ms
// Your runtime beats 12.00 % of csharp submissions.

public class Solution {
    public int[,] UpdateMatrix(int[,] matrix) 
    {
        var rows = matrix.GetLength(0);
        var cols = matrix.GetLength(1);
        var result = new int[rows,cols];
        for (int i = 0; i < rows; i++)
        {
            for (int j = 0; j < cols; j++)
                result[i,j] = (matrix[i,j] == 0) ? 0 : (Int32.MaxValue) >> 2;
        }
        var q = new Queue<Pair>();
        for (int r = 0; r < rows; r++)
        for (int c = 0; c < cols; c++)
            if (matrix[r,c] == 0)
                q.Enqueue(new Pair { R = r, C = c });
        int[] dirs = new int[] { 0, 1, 0, -1, 0 };
        int depth = 0;
        while (q.Count > 0)
        {
            int count = q.Count;
            depth++;
            while (count-- > 0)
            {
                var pop = q.Dequeue();
                for (int i = 0; i < 4; i++)
                {
                    var dr = dirs[i];
                    var dc = dirs[i + 1];
                    int r = pop.R + dr;
                    int c = pop.C + dc;
                    if (r < 0 || c < 0 || r >= rows || c >= cols) continue;
                    if (result[r,c] <= depth) continue;
                    result[r,c] = depth;
                    q.Enqueue(new Pair { R = r, C = c });
                }
            }
        }
        return result;
    }
    public class Pair
    {
        public int R;
        public int C;
    }
}
