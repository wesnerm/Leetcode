// 238. Product of Array Except Self   
// https://leetcode.com/problems/product-of-array-except-self
// Medium 48.5%
// 1266.358270765463
// Submission: https://leetcode.com/submissions/detail/67559435/
// Runtime: 552 ms
// Your runtime beats 6.32 % of csharp submissions.

public class Solution {
    public int[] ProductExceptSelf(int[] nums) {
        int[] output = new int[nums.Length];
                int product = 1;
        for (int i=0; i<nums.Length; i++)
        {
            output[i] = product;
            product *= nums[i];
        }
                product = 1;
        for (int i=nums.Length-1; i>=0; i--)
        {
            output[i] *= product;
            product *= nums[i];
        }
                return output;
    }
}
