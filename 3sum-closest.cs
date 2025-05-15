// 16. 3Sum Closest    
// https://leetcode.com/problems/3sum-closest
// Medium 31.1%
// 851.7875146517805
// Submission: https://leetcode.com/submissions/detail/71143632/
// Runtime: 180 ms
// Your runtime beats 37.38 % of csharp submissions.

public class Solution 
{
    public int ThreeSumClosest(int[] nums, int target) 
    {
        if (nums.Length<3) return nums.Sum();
        Array.Sort(nums);
        int closest = nums[0]+nums[1]+nums[2];
        for (int i=nums.Length-1; i>=2; i--)
        {
            int close2 = TwoSumClosest(nums, target-nums[i], i) + nums[i];
            closest = Closer(close2, closest, target);
        }
                return (int)closest;
    }
        int TwoSumClosest(int[] nums, int target, int n)
    {
        int closest = nums[0] + nums[n-1];
                int left = 0;
        int right = n-1;
        while (left<right)
        {
            int sum = nums[left] + nums[right];
            closest = Closer(closest, sum, target);
            if (sum < target)
                left++;
            else if (sum > target)
                right--;
            else 
                break;
        }
        return closest;
    }
        int Closer(int n1, int n2, long target)
    {
        return Math.Abs(n1-target) < Math.Abs(n2-target) ? n1 : n2;
    }
}
