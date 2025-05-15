// 216. Combination Sum III   
// https://leetcode.com/problems/combination-sum-iii
// Medium 44.1%
// 627.2369474182693
// Submission: https://leetcode.com/submissions/detail/71180717/
// Runtime: 432 ms
// Your runtime beats 6.82 % of csharp submissions.

public class Solution {
    public IList<IList<int>> CombinationSum3(int k, int n) {
        var list = new List<IList<int>>();
        Dfs(list, new List<int>(), k, n, 1);
        return list;
    }
        void Dfs(List<IList<int>> list, List<int> tempList, int k, int remain, int start)
    {
        if (k==0)
        {
            if (remain==0)
                list.Add(new List<int>(tempList));
            return;
        }
                if (remain <= 0)
            return;
        if (k==1)
        {
            if (remain>=start && remain<10)
            {
                var newList = new List<int>(tempList);
                newList.Add(remain);
                list.Add(newList);
            }
            return;
        }
        int limit = Math.Min(remain,9);
        for (int i=start; i<=limit; i++)
        {
            tempList.Add(i);
            Dfs(list, tempList, k-1, remain-i, i+1);
            tempList.RemoveAt(tempList.Count-1);
        }
    }
}
