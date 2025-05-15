// 120. Triangle   
// https://leetcode.com/problems/triangle
// Medium 33.3%
// 843.5760571061031
// Submission: https://leetcode.com/submissions/detail/70617935/
// Runtime: 172 ms
// Your runtime beats 25.58 % of csharp submissions.

public class Solution {
    public int MinimumTotal(IList<IList<int>> triangle) {
        int n = triangle.Count;
        var array = new int[n];
        for (int i=0; i<n; i++)
            array[i] = triangle[n-1][i];
        for (int i=n-2; i>=0; i--)
        {
            var list = triangle[i];
            for (int j=0; j<=i; j++)
                array[j] = list[j] + Math.Min(array[j],  array[j+1]);
        }
                return array[0];
    }
}
