// 548. Split Array with Equal Sum   
// https://leetcode.com/problems/split-array-with-equal-sum
// Medium 31.8%
// 172.72938790724334
// Submission: https://leetcode.com/submissions/detail/105459886/
// Runtime: 452 ms
// Your runtime beats 16.67 % of csharp submissions.

public class Solution {
    long[] presum;
    int[] nums;
    public bool SplitArray(int[] nums) {
        this.nums = nums;
        presum = new long[nums.Length];
        int n = nums.Length;
        long sum = 0;
        for(int i=0; i<nums.Length; i++)
            presum[i] = sum = sum + nums[i];
        var hashSet = new HashSet<long>();
        for (int j=2; j<n-2; j++)
        {
            hashSet.Clear();
                        for (int i=1; i+1<j; i++)
            {
                var v = ComputeSum(0,i-1); 
                if (v != ComputeSum(i+1,j-1)) continue;
                hashSet.Add(v);
            }              
                        for (int k=j+2; k<n-1; k++)
            {
                var v = ComputeSum(j+1,k-1);
                if (v != ComputeSum(k+1, n-1)) continue;
                if (hashSet.Contains(v))
                    return true;
            }
        }
                return false;
    }
        public long ComputeSum(int left, int right)
    {
        if (left == 0) return presum[right];
        return presum[right] - presum[left-1];
    }
}
