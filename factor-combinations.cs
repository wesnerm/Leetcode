// 254. Factor Combinations   
// https://leetcode.com/problems/factor-combinations
// Medium 41.9%
// 387.88846277623264
// Submission: https://leetcode.com/submissions/detail/71182387/
// Runtime: 428 ms
// Your runtime beats 72.22 % of csharp submissions.

public class Solution {
    public IList<IList<int>> GetFactors(int n) {
        var list = new List<IList<int>>();
        Dfs(list, new List<int>(), n, 2);
        return list;
    }
        void Dfs(List<IList<int>> list, List<int> tempList, int n, int lowerBound)
    {
        if (n == 1)
        {
            if (tempList.Count > 0)
                list.Add(new List<int>(tempList));
            return;
        }
            for (int i=lowerBound; i*i<=n; i++)
        {
            if (n%i!=0) continue;
            tempList.Add(i);
            Dfs(list, tempList, n/i, i);
            tempList.RemoveAt(tempList.Count-1);
        }
                if (tempList.Count > 0 && n>=lowerBound)
        {
            tempList.Add(n);
            Dfs(list, tempList, 1, lowerBound);
            tempList.RemoveAt(tempList.Count-1);
        }
    }
}
