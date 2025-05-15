// 34. Search for a Range   
// https://leetcode.com/problems/search-for-a-range
// Medium 31.2%
// 682.4733009408681
// Submission: https://leetcode.com/submissions/detail/70456833/
// Runtime: 488 ms
// Your runtime beats 21.87 % of csharp submissions.

public class Solution {
    public int[] SearchRange(int[] nums, int target) {
                int leftbound;
        int rightbound;
                int left = 0;
        int right = nums.Length-1;
        while (left<=right)
        {
            int mid = left+(right-left)/2;
            if (target<=nums[mid])
                right = mid-1;
            else
                left = mid+1;
        }
                leftbound = left;
                left = 0;
        right = nums.Length-1;
        while (left<=right)
        {
            int mid = left+(right-left)/2;
            if (target<nums[mid])
                right = mid-1;
            else
                left = mid+1;
        }
                rightbound = right;
                if (leftbound<=rightbound)
            return new int[] { leftbound, rightbound };
        return new [] { -1, -1 };
    }
}
