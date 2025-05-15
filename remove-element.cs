// 27. Remove Element   
// https://leetcode.com/problems/remove-element
// Easy 38.4%
// 1049.105349401638
// Submission: https://leetcode.com/submissions/detail/69989638/
// Runtime: 512 ms
// Your runtime beats 11.32 % of csharp submissions.

public class Solution {
    public int RemoveElement(int[] nums, int val) {
        int write = 0;
                for (int read=0; read<nums.Length; read++)
            if (nums[read] != val)
                nums[write++] = nums[read];
        return write;        
    }
}
