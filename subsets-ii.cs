// 90. Subsets II   
// https://leetcode.com/problems/subsets-ii
// Medium 35.4%
// 535.348551040133
// Submission: https://leetcode.com/submissions/detail/70760726/
// Runtime: 504 ms
// Your runtime beats 16.88 % of csharp submissions.

public class Solution {
    public IList<IList<int>> SubsetsWithDup(int[] nums) {
        var list = new List<IList<int>>();
        Array.Sort(nums);
        Backtrack(list, new List<int>(), nums, 0);
        return list;
    }
        void Backtrack(List<IList<int>> list, List<int> buf , int [] nums, int start)
    {
        if (start==nums.Length)
        {
            list.Add(new List<int>(buf));
            return;
        }
                int next = start;
        while (next<nums.Length && nums[next] == nums[start])
        {
            buf.Add(nums[start]);
            next++;
        }
        for (int i=next-start; i>=0; i--)
        {
            Backtrack(list, buf, nums, next);
            if (i>0)
                buf.RemoveAt(buf.Count-1);
        }
    }
}
