// 152. Maximum Product Subarray   
// https://leetcode.com/problems/maximum-product-subarray
// Medium 25.3%
// 1046.8943003658476
// Submission: https://leetcode.com/submissions/detail/70560441/
// Runtime: 180 ms
// Your runtime beats 5.68 % of csharp submissions.

public class Solution {
    public int MaxProduct(int[] nums) {
        int maxprod = 1;
        int minprod = 1;
        int best = int.MinValue;
                foreach(var n in nums)
        {
            int maxn = maxprod * n;
            int minn = minprod * n;
            maxprod = Math.Max(n, Math.Max(minn, maxn));
            minprod = Math.Min(n, Math.Min(minn, maxn));
            best = Math.Max(best, maxprod);
        }
        return best;
    }
}
