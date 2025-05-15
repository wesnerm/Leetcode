// 492. Construct the Rectangle   
// https://leetcode.com/problems/construct-the-rectangle
// Easy 48.9%
// 456.20352340782927
// Submission: https://leetcode.com/submissions/detail/101885954/
// Runtime: 362 ms
// Your runtime beats 52.24 % of csharp submissions.

public class Solution {
    public int[] ConstructRectangle(int area) {
        int sqrt = (int)Math.Ceiling(Math.Sqrt(area));
        for (int i=sqrt; i>=1; i--)
        {
            if (area == i*(area/i))
                return new int[] { Math.Max(i,area/i), Math.Min(i, area/i) };
        }
                return new int[] { area, 1 };
    }
}
