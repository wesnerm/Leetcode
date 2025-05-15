// 469. Convex Polygon   
// https://leetcode.com/problems/convex-polygon
// Medium 31.1%
// 197.0484440101829
// Submission: https://leetcode.com/submissions/detail/101885514/
// Runtime: 212 ms
// Your runtime beats 60.00 % of csharp submissions.

public class Solution {
    public bool IsConvex(IList<IList<int>> points) {
                var prev = points[points.Count-1];
        var prev2 = points[points.Count-2];
                int sign = 0;
        foreach(var p in points)
        {
            double a = prev2[0] - prev[0];
            double b = prev2[1] - prev[1];
            double c = prev[0] - p[0];
            double d = prev[1] - p[1];
                        var det = a*d - b*c;
            if (det != 0)
            {
                int sign2 = det > 0 ? 1 : -1;
                if (sign2 != sign && sign != 0)
                    return false;
                sign = sign2;
            }
            prev2 = prev;
            prev = p;
        }
                return true;
    }
}
