// 525. Contiguous Array   
// https://leetcode.com/problems/contiguous-array
// Medium 38.6%
// 331.4268961453315
// Submission: https://leetcode.com/submissions/detail/108666814/
// Runtime: 379 ms
// Your runtime beats 85.11 % of csharp submissions.

public class Solution {
    public int FindMaxLength(int[] nums) {
                Dictionary<int, int> dict = new  Dictionary<int, int> { {0,-1}};
                int sum = 0;
        int max = 0;
        for (int i=0; i<nums.Length; i++)
        {
            sum += (nums[i]==0 ? -1 : 1);
            if (dict.ContainsKey(sum))
                max = Math.Max(max, i-dict[sum]);
            else 
                dict[sum] = i;
        }
        return max;
    }
}
