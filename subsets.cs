// 78. Subsets   
// https://leetcode.com/problems/subsets
// Medium 39.3%
// 739.8573638295748
// Submission: https://leetcode.com/submissions/detail/70760034/
// Runtime: 504 ms
// Your runtime beats 14.58 % of csharp submissions.

public class Solution {
            public IList<IList<int>> Subsets(int[] nums) {
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
                buf.Add(nums[start]);
        Backtrack(list, buf, nums, start+1);
        buf.RemoveAt(buf.Count-1);
                Backtrack(list, buf, nums, start+1);
    }
}
