// 1. Two Sum   
// https://leetcode.com/problems/two-sum
// Easy 34.2%
// 5174.134026764635
// Submission: https://leetcode.com/submissions/detail/92220104/
// Runtime: 432 ms
// Your runtime beats 96.45 % of csharp submissions.

public class Solution {
    public int[] TwoSum(int[] nums, int target) {
        int[] array = new int[nums.Length];
        for (int i=0; i<nums.Length; i++)
            array[i] = i;
                //Array.Sort(array, (a,b)=>nums[a].CompareTo(nums[b]));
        //Array.Sort(nums);
        Array.Sort(nums, array);
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
                return new[] { array[left], array[right] };
        }
        return null;
    }
}
