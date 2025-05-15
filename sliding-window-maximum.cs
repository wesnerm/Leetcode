// 239. Sliding Window Maximum   
// https://leetcode.com/problems/sliding-window-maximum
// Hard 32.5%
// 673.0987325623116
// Submission: https://leetcode.com/submissions/detail/68459249/
// Runtime: 532 ms
// Your runtime beats 35.71 % of csharp submissions.

public class Solution {
    public int[] MaxSlidingWindow(int[] nums, int k) {
                var q = new int[k+1];
        int size = 0;
        int head = 0;
        int[] result = new int[nums.Length==0? 0: nums.Length-k+1];
                for (int i=0; i<nums.Length; i++)
        {
            // Remove indices that are two old
            while (size>0 && q[head] <= i-k)
            {
                head = (head+1) %k;
                size--;
            }
                        // Remove queue items less than max
            while (size>0 && nums[i]>nums[q[(head+size-1) % k]])
                size--;
            // Add max
            q[(head+size)%k] = i;
            size++;
            if (i>=k-1)
                result[i-k+1]=nums[q[head]];
        }
                return result;
    }
}
