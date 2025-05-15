// 322. Coin Change   
// https://leetcode.com/problems/coin-change
// Medium 26.3%
// 720.9485221796654
// Submission: https://leetcode.com/submissions/detail/71342270/
// Runtime: 196 ms
// Your runtime beats 44.05 % of csharp submissions.

public class Solution {
    public int CoinChange2(int[] coins, int amount) {
        Array.Sort(coins);
        var result = Dfs(coins, amount, coins.Length-1, 0, int.MaxValue);
        return (result != int.MaxValue) ? result : -1;
    }
        int Dfs(int[] coins, int amount, int i, int depth, int best)
    {
        if (amount == 0) return depth;
        if (amount < 0 || depth>=best || i<0) return int.MaxValue;
        int div = Math.Min(amount/coins[i], best-depth);
        if ( (div+1)*coins[i] < amount )
            return best;
                for (int j=div; j>=0; j--)
            best=Math.Min(best, Dfs(coins, amount-coins[i]*j, i-1, depth+j, best));
        return best;
    }
        public int CoinChange(int[] coins, int amount) {
        int [] dp = new int[amount+1];
                for (int i=1; i<=amount; i++)
        {
            dp[i] = int.MaxValue;
            foreach(var v in coins)
                if (v<=i && dp[i-v] != int.MaxValue)
                    dp[i] = Math.Min(dp[i], 1+dp[i-v]);
        }
                return dp[amount]==int.MaxValue ? -1 : dp[amount];
    }
        }
