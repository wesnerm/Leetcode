// 399. Evaluate Division   
// https://leetcode.com/problems/evaluate-division
// Medium 40.5%
// 470.09767492537287
// Submission: https://leetcode.com/submissions/detail/74815670/
// Runtime: 372 ms
// Your runtime beats 100.00 % of csharp submissions.

using System.Dynamic;
public class Solution {
    public double[] CalcEquation(string[,] equations, double[] values, string[,] queries)
    {
        var dict = new Dictionary<string, Dictionary<string, double>>();
        for (int i = 0; i < equations.GetLength(0); i++)
        {
            var n = equations[i, 0];
            var d = equations[i, 1];
            if (!dict.ContainsKey(n)) dict[n] = new Dictionary<string, double> { { n, 1 } };
            if (!dict.ContainsKey(d)) dict[d] = new Dictionary<string, double> { { d, 1 } };
            dict[n][d] = values[i];
            if (values[i] != 0) dict[d][n] = 1 / values[i];
        }
        return Enumerable.Range(0, queries.GetLength(0))
            .Select(i=>Dfs(queries[i,0], queries[i,1], new HashSet<string>(), dict) )
            .ToArray();
    }
    public double Dfs(string start, string end, HashSet<string> visited, Dictionary<string, Dictionary<string, double>> dict)
    {
        if (!dict.ContainsKey(start) || visited.Contains(start))
            return -1;
        if (dict[start].ContainsKey(end))
            return dict[start][end];
                    double ans = -1;
        visited.Add(start);
        foreach (var entry in dict[start])
        {
            var d = entry.Key;
            var r = entry.Value;
            if (d == end) return r;
            ans = Dfs(d, end, visited, dict);
            if (ans>=0)
            {
                ans = r * ans;
                break;
            }
        }
        visited.Remove(start);
        return ans;
    }
}
