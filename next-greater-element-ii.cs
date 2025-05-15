// 503. Next Greater Element II   
// https://leetcode.com/problems/next-greater-element-ii
// Medium 47.4%
// 308.51880027836137
// Submission: https://leetcode.com/submissions/detail/105460677/
// Runtime: 749 ms
// Your runtime beats 14.29 % of csharp submissions.

public class Solution {
    public int[] NextGreaterElements(int[] nums) {
        var result = new int[nums.Length];
        for (int i=0; i<nums.Length; i++)
        {
            var f = nums[i];
            var j = i;            
            int k;
            for (k=1; k<nums.Length; k++)
                if (nums[(j+k)%nums.Length]>f)
                    break;
                                if (k<nums.Length)
                result[i] = nums[(j+k)%nums.Length];
            else
                result[i] = -1;
        }
                return result;
    }
}
