// 40. Combination Sum II   
// https://leetcode.com/problems/combination-sum-ii
// Medium 32.9%
// 421.00021233667724
// Submission: https://leetcode.com/submissions/detail/71179238/
// Runtime: 528 ms
// Your runtime beats 18.52 % of csharp submissions.

public class Solution {
    public IList<IList<int>> CombinationSum2(int[] candidates, int target) {
        var list = new List<IList<int>>();
        Array.Sort(candidates);
        Dfs(list, new List<int>(), candidates, target, 0);
        return list;
    }
        void Dfs(List<IList<int>> list, List<int> tempList, int[] nums, int remain, int start)
    {
        if (remain < 0) return;
                if (remain == 0)
        {
            list.Add(new List<int>(tempList));
            return;
        }
                for (int i=start; i<nums.Length; i++)
        {
            if (i>start && nums[i] == nums[i-1]) continue;
            tempList.Add(nums[i]);
            Dfs(list, tempList, nums, remain-nums[i], i+1);
            tempList.RemoveAt(tempList.Count-1);
        }
    }
    }
