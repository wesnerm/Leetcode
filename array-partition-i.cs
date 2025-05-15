// 561. Array Partition I   
// https://leetcode.com/problems/array-partition-i
// Easy 68.8%
// 1025.0490918536602
// Submission: https://leetcode.com/submissions/detail/105459441/
// Runtime: 242 ms
// Your runtime beats 85.19 % of csharp submissions.

public class Solution {
    public int ArrayPairSum(int[] nums) {
             Array.Sort(nums);
        int s = 0;
        for (int i=0; i<nums.Length; i+=2)
            s+=nums[i];
        return s;
    }
}
