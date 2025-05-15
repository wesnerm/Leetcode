// 644. Maximum Average Subarray II   
// https://leetcode.com/problems/maximum-average-subarray-ii
// Hard 18.5%
// 433.30908305639343
// Submission: https://leetcode.com/submissions/detail/111778377/
// Runtime: 359 ms
// Your runtime beats 57.45 % of csharp submissions.

public class Solution {
    public double FindMaxAverage2(int[] nums, int k) {
        double average = double.MinValue;
        double sum =0;
        double[] presum = new double[nums.Length+1];
        for (int i=0; i<nums.Length; i++)
            presum[i+1] = sum += nums[i];
                for (int m=k; m<=2*k; m++)
        {
            for (int i=0; i+m<=nums.Length; i++)
            {
                var a = (presum[i+m]-presum[i])/m;
                if (a > average) average = a;
            }
        }
                return average;
    }
    public double FindMaxAverage(int[] nums, int k) {
                double left = nums.Min();
        double right = nums.Max();
                while (right - left > 1e-6 )
        {
            double mid = (left + right)/2;
            if (check(nums, mid, k))   
                left = mid;
            else
                right = mid;
        }
                return left;
    }
        public bool check(int[] nums, double mid, int k)
    {
        double sum = 0;
        double premin = 0;
        double presum = 0;
                for (int i=0; i<nums.Length; i++)
        {
            sum += nums[i] - mid;
            if (i>=k-1)
            {
                if (sum - premin >= 0)
                    return true;
                presum += nums[i-k+1] - mid;
                premin = Math.Min(presum, premin);
            }
        }
                return false;
    }
}
