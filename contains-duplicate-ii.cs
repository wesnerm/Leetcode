// 219. Contains Duplicate II   
// https://leetcode.com/problems/contains-duplicate-ii
// Easy 32.1%
// 997.8690274996223
// Submission: https://leetcode.com/submissions/detail/70384080/
// Runtime: 180 ms
// Your runtime beats 25.53 % of csharp submissions.

public class Solution {
    public bool ContainsNearbyDuplicate(int[] nums, int k) {
        var hash = new HashSet<int>();
        for (int i=0; i<nums.Length; i++)
        {
            if (i>k) hash.Remove(nums[i-k-1]);
            if (!hash.Add(nums[i]))
                return true;
        }
        return false;
    }
}
