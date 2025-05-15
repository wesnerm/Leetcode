// 228. Summary Ranges   
// https://leetcode.com/problems/summary-ranges
// Medium 29.2%
// 1005.2954877355892
// Submission: https://leetcode.com/submissions/detail/69817885/
// Runtime: 524 ms
// Your runtime beats 6.25 % of csharp submissions.

public class Solution {
    public IList<string> SummaryRanges(int[] nums) {
        var list = new List<string>();
        for (int i=0; i<nums.Length; i++)
        {
            int j = i;
            while (j+1<nums.Length && nums[j+1]==nums[j]+1) j++;
            list.Add( j==i ? nums[i].ToString() :nums[i] + "->" + nums[j]);
            i=j;
        }
                return list;        
    }
}
