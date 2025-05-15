// 123. Best Time to Buy and Sell Stock III   
// https://leetcode.com/problems/best-time-to-buy-and-sell-stock-iii
// Hard 28.9%
// 758.1362520674063
// Submission: https://leetcode.com/submissions/detail/70430911/
// Runtime: 176 ms
// Your runtime beats 24.14 % of csharp submissions.

public class Solution {
    public int MaxProfit(int[] prices) {
        int buy1 = int.MinValue;
        int buy2 = int.MinValue;
        int sell1 = 0;
        int sell2 = 0;
                foreach (int p in prices)
        {
            sell2 = Math.Max(sell2, buy2+p);
            buy2  = Math.Max(buy2, sell1-p);
            sell1 = Math.Max(sell1, buy1+p);
            buy1  = Math.Max(buy1, -p);
        }
                return sell2;
    }
/*    
    public int MaxProfit(int[] prices, int k=2)
    {
        return Sell(prices, prices.Length-1, k);
    }
        int Sell(int[] prices, int index, int k)
    {
        if (index<=0 || k==0) return 0;
        return Math.Max(
            Sell(prices, index-1, k),
            Buy(prices, index-1, k) + prices[index]);
    }
        int Buy(int[] prices, int index, int k)
    {
        if (index<0 || k==0) return int.MinValue;
        return Math.Max(
            Buy(prices, index-1, k),
            Sell(prices, index-1, k-1) - prices[index]);
    }
 */   
    }
