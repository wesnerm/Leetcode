// 334. Increasing Triplet Subsequence   
// https://leetcode.com/problems/increasing-triplet-subsequence
// Medium 38.8%
// 738.6811448846395
// Submission: https://leetcode.com/submissions/detail/70822514/
// Runtime: 172 ms
// Your runtime beats 20.83 % of csharp submissions.

public class Solution {
    public bool IncreasingTriplet(int[] nums) {
        int first = int.MaxValue;
        int second = int.MaxValue;
        foreach(var n in nums)
        {
            if (n <= first)
                first = n;
            else if (n <= second)
                second = n;
            else
                return true;
        }
                return false;
    }
}
