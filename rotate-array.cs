// 189. Rotate Array   
// https://leetcode.com/problems/rotate-array
// Easy 24.2%
// 951.0253700759522
// Submission: https://leetcode.com/submissions/detail/66643808/
// Runtime: 528 ms
// Your runtime beats 6.35 % of csharp submissions.

public class Solution {
    public void Rotate(int[] nums, int k) {
        if (nums.Length==0) return;
        k %= nums.Length;
        Reverse(nums, nums.Length-k, nums.Length);
        Reverse(nums, 0, nums.Length-k);
        Reverse(nums, 0, nums.Length);
    }
        public void Reverse(int[] nums, int start, int end)
    {
        int count = end - start;
        int mid = count/2;
        int mirror = end-1;
        for (int i=0; i<mid; i++)
        {
            int tmp = nums[start+i];
            nums[start+i] = nums[mirror-i];
            nums[mirror-i] = tmp;
        }
    }
}
