// 77. Combinations   
// https://leetcode.com/problems/combinations
// Medium 39.0%
// 700.3376761524066
// Submission: https://leetcode.com/submissions/detail/70761502/
// Runtime: 500 ms
// Your runtime beats 16.67 % of csharp submissions.

public class Solution {
    public IList<IList<int>> Combine(int n, int k) {
        var list = new List<IList<int>>();
        Backtrack(list, new List<int>(), n, k, 1);
        return list;        
    }
        void Backtrack(List<IList<int>> list, List<int> buf , int n, int k, int start)
    {
        if (k==0)
        {
            list.Add(new List<int>(buf));
            return;
        }
                if (start>n)
            return;
                buf.Add(start);
        Backtrack(list, buf, n, k-1, start+1);
        buf.RemoveAt(buf.Count-1);
                Backtrack(list, buf, n, k, start+1);
    }
}
