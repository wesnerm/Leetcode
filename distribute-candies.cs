// 575. Distribute Candies   
// https://leetcode.com/problems/distribute-candies
// Easy 60.0%
// 292.38356135298756
// Submission: https://leetcode.com/submissions/detail/105459077/
// Runtime: 529 ms
// Your runtime beats 34.23 % of csharp submissions.

public class Solution {
    public int DistributeCandies(int[] candies) {
        var dict = new Dictionary<int, int>();
        foreach(var v in candies)
        {
            if (!dict.ContainsKey(v)) dict[v] = 0;
            dict[v]++;
        }
        return Math.Min(candies.Length/2, dict.Count);
    }
}
