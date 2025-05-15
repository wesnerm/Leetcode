// 167. Two Sum II - Input array is sorted   
// https://leetcode.com/problems/two-sum-ii-input-array-is-sorted
// Easy 47.1%
// 726.6950125853843
// Submission: https://leetcode.com/submissions/detail/68931447/
// Runtime: 509 ms
// Your runtime beats 10.10 % of csharp submissions.

public class Solution {
    public int[] TwoSum(int[] nums, int target) {
        int left = 0;
        int right = nums.Length-1;
        while (left < right)
        {
            int sum = nums[left]+nums[right];
            if (sum < target)
                left++;
            else if (sum > target)
                right--;
            else
                return new[] { left+1, right+1 };
        }
        return null;        
    }
}
