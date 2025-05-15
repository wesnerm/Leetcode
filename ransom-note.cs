// 383. Ransom Note   
// https://leetcode.com/problems/ransom-note
// Easy 46.8%
// 889.9001462063353
// Submission: https://leetcode.com/submissions/detail/70094652/
// Runtime: 136 ms
// Your runtime beats 58.11 % of csharp submissions.

public class Solution {
    public bool CanConstruct(string ransomNote, string magazine) {
        var dict = new int[256];
        foreach(var w in magazine)
            dict[w]++;
                    foreach(var w in ransomNote)
            if (dict[w]-- <= 0)
                return false;
                        return true;
    }
}
