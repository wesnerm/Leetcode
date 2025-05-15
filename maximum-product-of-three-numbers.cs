// 628. Maximum Product of Three Numbers   
// https://leetcode.com/problems/maximum-product-of-three-numbers
// Easy 45.3%
// 626.9811751207338
// Submission: https://leetcode.com/submissions/detail/107384761/
// Runtime: 255 ms
// Your runtime beats 53.94 % of csharp submissions.

public class Solution {
    public int MaximumProduct(int[] nums) {
        Array.Sort(nums);
                var list = new List<int>();
                for (int i=0; i<3; i++)
            list.Add(nums[i]);
                    for (int i=Math.Max(nums.Length-3,3); i<nums.Length; i++)
            list.Add(nums[i]);
        int min = int.MinValue;
        for (int i=0; i<list.Count; i++)
            for (int j=i+1; j<list.Count; j++)
                for (int k=j+1; k<list.Count; k++)
                {
                    int product = list[i] * list[j] * list[k];
                    min =Math.Max(product, min);
                }
        return min;
    }
}
