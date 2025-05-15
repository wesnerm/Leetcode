// 410. Split Array Largest Sum   
// https://leetcode.com/problems/split-array-largest-sum
// Hard 35.9%
// 487.5105571476702
// Submission: https://leetcode.com/submissions/detail/101881438/
// Runtime: 749 ms
// Your runtime beats 0.00 % of csharp submissions.

public class Solution {
    public int SplitArray(int[] nums, int m) {
        var cache = new int [nums.Length,m+1];
        return dfs(nums,m,0, cache);
                    }
        public int dfs(int [] nums, int m, int start, int[,] cache)
    {
        if (m<=0) return start==nums.Length?0:int.MaxValue;
                if (cache[start,m]!=0)
            return cache[start,m];
                int sum = 0;
        if (m==1)
        {
            for (int i=start; i<nums.Length;i++)
                sum+= nums[i];
            return sum;
        }
        int minmax = int.MaxValue;
        int m1 = m-1;
        for (int i=start+1; i<nums.Length; i++)
        {
            sum += nums[i-1];
            var sum2 = dfs(nums, m1, i, cache);
            int max = Math.Max(sum, sum2);
            minmax = Math.Min(max, minmax);
        }
                cache[start,m] = minmax;
        return minmax;
    }
}
