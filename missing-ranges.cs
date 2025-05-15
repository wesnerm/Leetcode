// 163. Missing Ranges   
// https://leetcode.com/problems/missing-ranges
// Medium 25.2%
// 521.113929773707
// Submission: https://leetcode.com/submissions/detail/67596234/
// Runtime: 500 ms
// Your runtime beats 38.10 % of csharp submissions.

public class Solution {
        int[] nums;
    int lower;
    int upper;
        public IList<string> FindMissingRanges(int[] nums, int lower, int upper) {
        var list = new List<string>();
                this.nums = nums;
        this.lower = lower;
        this.upper = upper;
                int start=lower;
        for (int i=0; i<nums.Length; i++)
        {
            AppendRange(list, start, nums[i]-1);
                while (i+1<nums.Length && nums[i+1]==nums[i]+1)
                i++;
                        start = nums[i]+1;
        }
        AppendRange(list, start, upper);
        return list;
    }
        void AppendRange(List<string> list, int start, int end)
    {
        if (start > end)
            return;
                if (start == end)
            list.Add(start.ToString());
        else
            list.Add(start + "->" + end);
    }
}
