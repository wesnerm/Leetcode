// 188. Best Time to Buy and Sell Stock IV   
// https://leetcode.com/problems/best-time-to-buy-and-sell-stock-iv
// Hard 24.1%
// 881.3002017810184
// Submission: https://leetcode.com/submissions/detail/70433232/
// Runtime: 452 ms
// Your runtime beats 11.54 % of csharp submissions.

public class Solution {
        public int MaxProfit(int k, int[] prices) {
        int len = prices.Length;
        if (len < 2) return 0;
        if (k>len/2) k = len/2;   
            int[] buy = new int[k+1];
        int[] sell = new int[k+1];
                for (int i=0; i<=k; i++)
            buy[i] = int.MinValue;
                    for (int i=0; i<len; i++)
        {
            int p = prices[i];
            for (int j=k; j>0; j--)
            {
                sell[j] = Math.Max(sell[j], buy[j] + p);
                buy[j] = Math.Max(buy[j], sell[j-1] - p);
            }
        }
        return sell[k];            
    }
        /*
    public int MaxProfit(int k, int[] prices)
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
