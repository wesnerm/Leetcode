// 26. Remove Duplicates from Sorted Array   
// https://leetcode.com/problems/remove-duplicates-from-sorted-array
// Easy 35.6%
// 1029.8163404129843
// Submission: https://leetcode.com/submissions/detail/69992053/
// Runtime: 480 ms
// Your runtime beats 37.50 % of csharp submissions.

public class Solution {
    public int RemoveDuplicates(int[] nums) {
        int write = 0;
        for (int read=0; read < nums.Length; read++)
            if (read==0 || nums[read-1] != nums[read])
                nums[write++] = nums[read];
        return write;
    }
}
