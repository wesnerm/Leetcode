// 645. Set Mismatch   
// https://leetcode.com/problems/set-mismatch
// Easy 41.1%
// 171.51396477128444
// Submission: https://leetcode.com/submissions/detail/111483354/
// Runtime: 689 ms
// Your runtime beats 18.75 % of csharp submissions.

using System.Linq;
public class Solution {
    public int[] FindErrorNums(int[] nums) {
                Array.Sort(nums);
        int dup = 0;
        int prev = 0;
        for (int i=0; i<nums.Length; i++)
        {
            var n = nums[i];
            if (n==prev)
                dup = n;
            prev = n;
        }
        var set = new HashSet<int>(nums);
        int missing = Enumerable.Range(1, nums.Length).First(x=>!set.Contains(x));
                return new int[] { dup, missing };
    }
}
