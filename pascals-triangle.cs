// 118. Pascal's Triangle   
// https://leetcode.com/problems/pascals-triangle
// Easy 38.0%
// 1044.0503055967017
// Submission: https://leetcode.com/submissions/detail/70379473/
// Runtime: 408 ms
// Your runtime beats 10.99 % of csharp submissions.

public class Solution {
    public IList<IList<int>> Generate(int numRows)
    {
        var list = new List<IList<int>>();
                for (int i=0; i<numRows; i++)
        {
            var prev = i>0 ? list[i-1] : null;
            var cur = new List<int>();
            list.Add(cur);
            cur.Add(1);
            for (int j=1; j<i; j++)
                cur.Add(prev[j-1]+prev[j]);
            if (i>0)
                cur.Add(1);
        }
        return list;
    }
}
