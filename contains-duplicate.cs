// 217. Contains Duplicate   
// https://leetcode.com/problems/contains-duplicate
// Easy 45.1%
// 1217.075262734526
// Submission: https://leetcode.com/submissions/detail/68930027/
// Runtime: 192 ms
// Your runtime beats 20.57 % of csharp submissions.

public class Solution {
    public bool ContainsDuplicate(int[] nums) {
        Array.Sort(nums);
        for (int i=1; i<nums.Length; i++)
        {
            if (nums[i-1]==nums[i]) 
                return true;
        }
        return false;
    }
}
