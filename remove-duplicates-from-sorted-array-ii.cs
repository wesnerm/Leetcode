// 80. Remove Duplicates from Sorted Array II   
// https://leetcode.com/problems/remove-duplicates-from-sorted-array-ii
// Medium 35.6%
// 678.7827548297403
// Submission: https://leetcode.com/submissions/detail/70121073/
// Runtime: 500 ms
// Your runtime beats 11.86 % of csharp submissions.

public class Solution {
    public int RemoveDuplicates(int[] nums) {
         int write=0;
        int dupes = 0;
        for (int read=0; read<nums.Length; read++)
            if (write<2 || nums[read] != nums[write-2])
                nums[write++] = nums[read];
        return write;
    }
}
