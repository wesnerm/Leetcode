// 465. Optimal Account Balancing   
// https://leetcode.com/problems/optimal-account-balancing
// Hard 36.0%
// 296.37054698517017
// Submission: https://leetcode.com/submissions/detail/111588974/
// Runtime: 192 ms
// Your runtime beats 66.67 % of csharp submissions.

public class Solution {
    public int MinTransfers(int[,] transactions) {
                var dict = new Dictionary<int, int>();
                for (int i=0; i<transactions.GetLength(0); i++)
        {
            int src = transactions[i,0];
            int dst = transactions[i,1];
            int amt = transactions[i,2];
                        if (!dict.ContainsKey(src)) dict[src]=0;
            if (!dict.ContainsKey(dst)) dict[dst]=0;
            dict[src] -= amt;
            dict[dst] += amt;
        }
        var debts = dict.Values.Where(x=>x!=0).ToArray();
        Array.Sort(debts);
        return Dfs(debts, 0, 0);
    }
        public int Dfs(int[] debts, int index, int cnt)
    {
        while (index < debts.Length && debts[index]==0) index++;
                int min = int.MaxValue;
        for (int i=index+1; i<debts.Length; i++)
        {
            if (debts[i]*debts[index] < 0)
            {
                debts[i] += debts[index];
                min = Math.Min(min, Dfs(debts, index+1, cnt+1));
                debts[i] -= debts[index];
            }
        }
                return min < int.MaxValue ? min : cnt;
    }
}
