// 506. Relative Ranks   
// https://leetcode.com/problems/relative-ranks
// Easy 47.0%
// 530.1999019704797
// Submission: https://leetcode.com/submissions/detail/105460741/
// Runtime: 505 ms
// Your runtime beats 74.19 % of csharp submissions.

using System;
public class Solution {
    public string[] FindRelativeRanks(int[] scores) {
        int [] indices = new int[scores.Length];
        string [] results = new string[scores.Length];
                for (int i=0; i<indices.Length; i++)
            indices[i] = i;
                Array.Sort(scores, indices);
        Array.Reverse(scores);
        Array.Reverse(indices);
                for (int i=0; i<scores.Length; i++)
            results[indices[i]] = (i+1).ToString();
        if (scores.Length > 0)
            results[indices[0]] = "Gold Medal";
        if (scores.Length > 1)
            results[indices[1]] = "Silver Medal";
        if (scores.Length > 2)
            results[indices[2]] = "Bronze Medal";
                return results;
    }
}
