// 121. Best Time to Buy and Sell Stock   
// https://leetcode.com/problems/best-time-to-buy-and-sell-stock
// Easy 40.6%
// 1323.8583709992386
// Submission: https://leetcode.com/submissions/detail/70437036/
// Runtime: 164 ms
// Your runtime beats 18.30 % of csharp submissions.

public class Solution {
    public int MaxProfit(int[] prices)
    {
        int sell = 0;
        int buy = int.MinValue;
        for (int i=0; i<prices.Length; i++)
        {
            sell = Math.Max(sell, buy + prices[i]);
            buy = Math.Max(buy, -prices[i]);
        }
        return sell;
    }
}
