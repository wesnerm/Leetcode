// 587. Erect the Fence   
// https://leetcode.com/problems/erect-the-fence
// Hard 28.9%
// 82.85598578528844
// Submission: https://leetcode.com/submissions/detail/105458872/
// Runtime: 662 ms
// Your runtime beats 16.67 % of csharp submissions.

/**
 * Definition for a point.
 * public class Point {
 *     public int x;
 *     public int y;
 *     public Point() { x = 0; y = 0; }
 *     public Point(int a, int b) { x = a; y = b; }
 * }
 */
public class Solution {
    public IList<Point> OuterTrees(Point[] pts) {
        Array.Sort(pts, (a,b)=>
        {
          int cmp = a.x.CompareTo(b.x);
          if (cmp != 0) return cmp;
          return a.y.CompareTo(b.y);
        });
        var up = new List<Point>();
        var down = new List<Point>();
        for (var i = 0; i < pts.Length; i++)
        {
            while (up.Count > 1 && Area2(up[up.Count - 2], up[up.Count - 1], pts[i]) >= eps) up.RemoveAt(up.Count-1);
            while (down.Count > 1 && Area2(down[down.Count - 2], down[down.Count - 1], pts[i]) <= -eps) down.RemoveAt(down.Count-1);
            up.Add(pts[i]);
            down.Add(pts[i]);
        }
        for (var i = up.Count - 2; i >= 1; i--)
        {
            if (!down.Contains(up[i]))
                down.Add(up[i]);
        }
        return down;
            }
    const double eps = 1e-7;
    private static double Cross(Point p, Point q)
    {
        return p.x*q.y - p.y*q.x;
    }
    private static double Area2(Point a, Point b, Point c)
    {
        return Cross(a, b) + Cross(b, c) + Cross(c, a);
    }
    private static bool Between(Point a, Point b, Point c)
    {
        return Math.Abs(Area2(a, b, c)) < 1e-9 && (a.x - b.x)*(c.x - b.x) <= 0 && (a.y - b.y)*(c.y - b.y) <= 0;
    }
}
