// 209. Minimum Size Subarray Sum    
// https://leetcode.com/problems/minimum-size-subarray-sum
// Medium 30.0%
// 609.7546299667218
// Submission: https://leetcode.com/submissions/detail/71284778/
// Runtime: 162 ms
// Your runtime beats 36.36 % of csharp submissions.

public class Solution 
{
    public int MinSubArrayLen2(int s, int[] nums) {
        int start = 0;
        int sum = 0;
        int minlen = int.MaxValue;
                for (int end=0; end<nums.Length; end++)
        {
            sum += nums[end];
            if (sum >= s) minlen = Math.Min(minlen, end-start+1);
                        while (sum>s && start<end)
            {
                sum -= nums[start++];
                if (sum >= s) minlen = Math.Min(minlen, end-start+1);
            }
        }
        return minlen==int.MaxValue ? 0 : minlen;
    }
        public int MinSubArrayLen(int s, int[] nums) {
        int start = 0;
        int sum = 0;
        int minlen = int.MaxValue;
                int[] sums = new int[nums.Length+1];
        for (int i = 1; i<sums.Length; i++)
            sums[i] = sums[i-1] + nums[i-1];
        for (int i=0; i<sums.Length; i++)
        {
            if (sums[i]<s) continue;
                        // sums[i] - sums[j] >= s
            // find last sums[j] <= sums[i]-s such that j<i
            // length = i - j
            int j = BinSearch(sums, sums[i]-s, i);
            if (i>j)
                minlen = Math.Min(minlen, i - j);
        }
        return minlen==int.MaxValue ? 0 : minlen;
    }
        public int BinSearch(int[] sums, int target, int count)
    {
        int start = 0;
        int end = count-1;
        while (start<=end)
        {
            int mid = start + (end-start)/2;
                        if (target >= sums[mid])  // sums[start] > target
                start = mid+1;
            else
                end = mid-1;        // sums[end] <= target
        }
        return end;
    }
        }
