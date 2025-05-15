// 283. Move Zeroes   
// https://leetcode.com/problems/move-zeroes
// Easy 49.3%
// 1406.3233053412603
// Submission: https://leetcode.com/submissions/detail/69994417/
// Runtime: 592 ms
// Your runtime beats 3.73 % of csharp submissions.

public class Solution {
    public void MoveZeroes(int[] nums) {
        int write =0;
        foreach (var ch in nums)
            if (ch!=0)
                nums[write++] = ch;
        while (write<nums.Length)
            nums[write++] = 0;
    }
}
