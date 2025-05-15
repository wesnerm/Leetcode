// 15. 3Sum   
// https://leetcode.com/problems/3sum
// Medium 21.6%
// 1198.8734850604485
// Submission: https://leetcode.com/submissions/detail/67726703/
// Runtime: 500 ms
// Your runtime beats 99.66 % of csharp submissions.

public class Solution {
    public IList<IList<int>> ThreeSum(int[] nums) {
        var list = new List<IList<int>>();
                Array.Sort(nums);
        for (int i=0; i<nums.Length; i++)
        {
            if (i>0 && nums[i] == nums[i-1])
                continue;
            int left = i+1;
            int right = nums.Length-1;
            int tmpTarget = -nums[i];
            while (left < right)
            {
                int sum = nums[left]+nums[right];
                if (sum < tmpTarget)
                    left++;
                else if (sum > tmpTarget)
                    right--;
                else
                {
                    list.Add(new[] { nums[i], nums[left], nums[right] });
                    while (left < right && nums[left]==nums[left+1]) left++;
                    while (left < right && nums[right]==nums[right-1]) right--;
                    left++;
                    right--;
                }
            }
        }
        return list;
    }
}
