// 386. Lexicographical Numbers   
// https://leetcode.com/problems/lexicographical-numbers
// Medium 40.6%
// 818.3197554605048
// Submission: https://leetcode.com/submissions/detail/105463465/
// Runtime: 759 ms
// Your runtime beats 10.34 % of csharp submissions.

public class Solution {
    public IList<int> LexicalOrder(int n) {
        var list = new List<int>();
        for (int i=1; i<=9; i++)
            Dfs(list, n, i);
        return list;
    }
        void Dfs(List<int> list, int n, int prefix)
    {
        if (prefix<=n)
        {
            list.Add(prefix);
            for (int i=0; i<=9; i++)
                Dfs(list, n, prefix*10+i);
        }
    }
}
