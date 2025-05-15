// 287. Find the Duplicate Number   
// https://leetcode.com/problems/find-the-duplicate-number
// Medium 42.9%
// 971.0860866384096
// Submission: https://leetcode.com/submissions/detail/71447417/
// Runtime: 176 ms
// Your runtime beats 11.24 % of csharp submissions.

public class Solution {
    public int FindDuplicate2(int[] nums) {
        int slow = nums[0];
        int fast = nums[nums[0]];
        while (slow != fast)
        {
            slow = nums[slow];
            fast = nums[nums[fast]];
        }
                slow = 0;
        while (slow != fast)
        {
            slow = nums[slow];
            fast = nums[fast];
        }
        return slow;
    }
    public int FindDuplicate(int[] nums) {
        int left = 1;
        int right = nums.Length-1;
                while (left<right)
        {
            int mid = (left+right)/2;
                        int count = 0;
            foreach(var n in nums)
                if (n<=mid)
                    count++;
                        if (count>mid)
                right=mid; // we use = because we include n<=mid in the count
            else
                left=mid+1;
        }
                return left;
    }
        // Also binary search version
}
