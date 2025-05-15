// 280. Wiggle Sort   
// https://leetcode.com/problems/wiggle-sort
// Medium 56.5%
// 729.778760775549
// Submission: https://leetcode.com/submissions/detail/68038857/
// Runtime: 532 ms
// Your runtime beats 16.00 % of csharp submissions.

public class Solution 
{
    public void WiggleSort(int[] nums) 
    {
        for (int i=1; i<nums.Length; i++)
        {
            if ((i%2==1) == (nums[i-1]>nums[i]))
            {
                int tmp = nums[i];
                nums[i] = nums[i-1];
                nums[i-1] = tmp;
            }
        }
    }
}
