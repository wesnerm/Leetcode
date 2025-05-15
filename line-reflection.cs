// 356. Line Reflection   
// https://leetcode.com/problems/line-reflection
// Medium 30.2%
// 126.6391512899936
// Submission: https://leetcode.com/submissions/detail/69589426/
// Runtime: 192 ms
// Your runtime beats 80.00 % of csharp submissions.

public class Solution {
    public bool IsReflected(int[,] points) {
        int max = int.MinValue;
        int min = int.MaxValue;
        int pointCount = points.GetLength(0);
                HashSet<string> set = new HashSet<string>();
        for(int i=0; i<pointCount; i++)
        {
            max = Math.Max(points[i,0], max);
            min = Math.Min(points[i,0], min);
            var str = points[i,0]+"a"+points[i,1];
            set.Add(str);
        }
                int sum = max+min;
        for(int i=0; i<pointCount; i++)
        {
            var str = (sum-points[i,0]) + "a" + points[i,1];
            if (!set.Contains(str))
                return false;
        }
                return true;
    }
}
