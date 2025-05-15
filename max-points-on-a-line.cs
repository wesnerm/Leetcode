// 149. Max Points on a Line   
// https://leetcode.com/problems/max-points-on-a-line
// Hard 15.4%
// 1143.206088844607
// Submission: https://leetcode.com/submissions/detail/70544895/
// Runtime: 180 ms
// Your runtime beats 63.64 % of csharp submissions.

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
    public int MaxPoints(Point[] points) 
    {
        int maxlen = 0;
        for (int i=0; i<points.Length; i++)
        {
            int sameCount = 0;
            int sameSlope = 0;
            var slopes = new Dictionary<double, int>();
            for (int j=0; j<points.Length; j++)
            {
                if (points[i].x==points[j].x && points[i].y==points[j].y)
                {
                    sameCount++;
                }
                else
                {
                    var slope = (double)(points[i].y - points[j].y)/(points[i].x-points[j].x);
                    if (!slopes.ContainsKey(slope))
                        slopes[slope] = 0;
                    slopes[slope]++;
                    sameSlope = Math.Max(sameSlope, slopes[slope]);
                }
            }
            maxlen = Math.Max(maxlen, sameCount + sameSlope);
        }
        return maxlen;
    }
}
