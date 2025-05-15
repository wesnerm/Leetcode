// 39. Combination Sum    
// https://leetcode.com/problems/combination-sum
// Medium 37.7%
// 761.5505600904721
// Submission: https://leetcode.com/submissions/detail/71178898/
// Runtime: 496 ms
// Your runtime beats 30.23 % of csharp submissions.

public class Solution {
    public IList<IList<int>> CombinationSum(int[] candidates, int target) {
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
            tempList.Add(nums[i]);
            Dfs(list, tempList, nums, remain-nums[i], i);
            tempList.RemoveAt(tempList.Count-1);
        }
    }
    }
