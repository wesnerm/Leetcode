// 162. Find Peak Element   
// https://leetcode.com/problems/find-peak-element
// Medium 36.9%
// 862.0615529377034
// Submission: https://leetcode.com/submissions/detail/68460839/
// Runtime: 152 ms
// Your runtime beats 24.75 % of csharp submissions.

public class Solution {
    public int FindPeakElement(int[] nums) {
        return helper(nums, 0, nums.Length-1);
    }
        int helper(int [] num, int start, int end)
    {
        if (start==end)
            return start;
                int mid = (start+end)/2;
        if (num[mid] > num[mid+1])
            return helper(num,start,mid);
        return helper(num,mid+1,end);
    }
}
