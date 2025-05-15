// 360. Sort Transformed Array    
// https://leetcode.com/problems/sort-transformed-array
// Medium 43.8%
// 317.5111481007154
// Submission: https://leetcode.com/submissions/detail/69496544/
// Runtime: 500 ms
// Your runtime beats 20.00 % of csharp submissions.

public class Solution {
    public int[] SortTransformedArray(int[] nums, int a, int b, int c) {
        var quad = new int[nums.Length];
        for (int i=0; i<quad.Length; i++)
        {
            int x = nums[i];
            quad[i] = (a*x + b)*x + c;
        }
                var result = new int[nums.Length];
        int r = a<=0 ? 0 : nums.Length-1;
        int left=0;
        int right=nums.Length-1;
        while (left<=right)
        {
            if (a<=0)
                result[r++] = quad[left]<quad[right] ? quad[left++] : quad[right--];
            else
                result[r--] = quad[left]<quad[right] ? quad[right--] : quad[left++];
        }   
        return result;
    }
}
