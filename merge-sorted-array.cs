// 88. Merge Sorted Array   
// https://leetcode.com/problems/merge-sorted-array
// Easy 31.8%
// 1036.8456403380571
// Submission: https://leetcode.com/submissions/detail/70153649/
// Runtime: 484 ms
// Your runtime beats 16.48 % of csharp submissions.

public class Solution {
    public void Merge(int[] nums1, int m, int[] nums2, int n) {
        int i = m+n-1;
                while (m>0 && n>0)
            nums1[i--] = (nums1[m-1]>=nums2[n-1]) ? nums1[--m] : nums2[--n];
        while (m-->0)
            nums1[i--] = nums1[m];
                while (n-->0)
            nums1[i--] = nums2[n];
    }
}
