// 122. Best Time to Buy and Sell Stock II   
// https://leetcode.com/problems/best-time-to-buy-and-sell-stock-ii
// Easy 46.5%
// 1245.5874067027282
// Submission: https://leetcode.com/submissions/detail/70437173/
// Runtime: 180 ms
// Your runtime beats 9.09 % of csharp submissions.

public class Solution {
    public int MaxProfit(int[] prices) {
        int total =0;
        for (int i=0; i<prices.Length-1; i++)
            total += Math.Max(0, prices[i+1] - prices[i]);
        return total;
    }
}
