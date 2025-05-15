// 164. Maximum Gap   
// https://leetcode.com/problems/maximum-gap
// Hard 29.2%
// 974.2772174771416
// Submission: https://leetcode.com/submissions/detail/71311691/
// Runtime: 168 ms
// Your runtime beats 17.86 % of csharp submissions.

public class Solution {
    public int MaximumGap(int[] nums) {
        if (nums.Length<2) return 0;
        int maxgap = 0;
                int min = int.MaxValue;
        int max = int.MinValue;
        foreach(var n in nums)
        {
            min = Math.Min(min, n);
            max = Math.Max(max, n);
        }
                var buckets = new Bucket[nums.Length+1];
        foreach(var n in nums)
        {
            if (n==min || n==max) continue;
            long b = ((long)n-min)*nums.Length/(max-min);
            if (buckets[b] == null) buckets[b] = new Bucket();
            buckets[b].Add(n);
        }
        int prev = min;
        foreach(var b in buckets)
        {
            if (b==null) continue;
            maxgap = Math.Max(b.Min-prev, maxgap);
            prev = b.Max;
        }
        maxgap = Math.Max(max-prev, maxgap);
                        return maxgap;
    }
        public class Bucket
    {
        public int Min = int.MaxValue;
        public int Max = int.MinValue;
        public void Add(int num)
        {
            Min = Math.Min(Min, num);
            Max = Math.Max(Max, num);
        }
    }
}
