// 18. 4Sum   
// https://leetcode.com/problems/4sum
// Medium 26.4%
// 701.8873824328591
// Submission: https://leetcode.com/submissions/detail/71147215/
// Runtime: 580 ms
// Your runtime beats 17.50 % of csharp submissions.

public class Solution {
    public IList<IList<int>> FourSum(int[] nums, int target) {
        Array.Sort(nums);
        var list = new List<IList<int>>();
                var set = new HashSet<int>();
        for (int i=0; i<nums.Length; i++)
        {
            if (i>0 && nums[i]==nums[i-1]) continue;
            for (int j=i+1; j<nums.Length; j++)
            {
                if (j>i+1 && nums[j] == nums[j-1]) continue;
                int left = j+1;
                int right = nums.Length-1;
                int t = target - nums[i] - nums[j];
                while (left<right)
                {
                    int sum = nums[left] + nums[right];
                    if (sum < t)
                        left++;
                    else if (sum > t)
                        right--;
                    else
                    {
                        var found = new int[]{ nums[i], nums[j], nums[left], nums[right] };
                        list.Add(found);
                                                    while (left<right && nums[left]==nums[left+1]) left++;
                        while (left<right && nums[right]==nums[right-1]) right--;
                        left++;
                        right--;
                    }
                }
            }
        }
                return list;
    }
/*
    public IList<IList<int>> FourSum2(int[] nums, int target) {
        var set = new HashSet<int>();
        for (int i=0; i<nums.Length; i++)
            for (int j=i+1; j<nums.Length; j++)
                set.Add(nums);
                var list
    }
*/
    }
