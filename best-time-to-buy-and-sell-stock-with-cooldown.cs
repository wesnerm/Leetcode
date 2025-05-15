// 309. Best Time to Buy and Sell Stock with Cooldown    
// https://leetcode.com/problems/best-time-to-buy-and-sell-stock-with-cooldown
// Medium 40.3%
// 686.9594112739212
// Submission: https://leetcode.com/submissions/detail/70434843/
// Runtime: 172 ms
// Your runtime beats 19.44 % of csharp submissions.

public class Solution {
        public int MaxProfit(int[] prices) {
        int buy = int.MinValue;
        int sell_2 = 0;
        int sell = 0;
                for (int i=0; i<prices.Length; i++)
        {
            int sellOld = sell;
            sell = Math.Max(buy+prices[i], sell);
            buy = Math.Max(sell_2-prices[i], buy);
            sell_2 = sellOld;
        }
                return sell;
    }
    /*
    public int MaxProfit(int [] prices)
    {
        return Sell(prices, prices.Length-1);
    }
        public int Sell(int [] prices, int index)
    {
        if (index<=0) return 0;
        return Math.Max(Sell(prices, index-1),
                        Buy(prices, index-1) + prices[index]);
    }
        public int Buy(int [] prices, int index)
    {
        if (index<0) return int.MinValue;
        return Math.Max(Buy(prices, index-1),
                        Sell(prices, index-2) - prices[index]);
    }
    */
}
