// 416. Partition Equal Subset Sum   
// https://leetcode.com/problems/partition-equal-subset-sum
// Medium 38.6%
// 359.1567710184115
// Submission: https://leetcode.com/submissions/detail/78090638/
// Runtime: 142 ms
// Your runtime beats 100.00 % of csharp submissions.

public class Solution 
{
    int[] nums;
    public bool CanPartition(int[] nums) {
        this.nums = nums;
                if (nums.Length==0) return true;
                int total = nums.Sum();
        if (total % 2 == 1) return false;
        Array.Sort(nums);
        return Dfs(nums.Length-2, total/2 - nums[nums.Length-1]);
    }
        public bool Dfs(int index, int sum)
    {
        if (sum <= 0) return sum==0;
        if (index < 0) return false;
                return Dfs(index-1, sum-nums[index]) || Dfs(index-1, sum);
    }
}
