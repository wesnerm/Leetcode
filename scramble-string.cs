// 87. Scramble String   
// https://leetcode.com/problems/scramble-string
// Hard 28.8%
// 682.301067987414
// Submission: https://leetcode.com/submissions/detail/70776706/
// Runtime: 172 ms
// Your runtime beats 8.00 % of csharp submissions.

public class Solution {
    public bool IsScramble(string s1, string s2) {
        if (s1==s2)
            return true;
        if (s1.Length != s2.Length)
            return false;
                    var map = new Dictionary<char, int>();
        foreach(var c in s1)
            map[c] = map.ContainsKey(c) ? map[c]+1 : 1;
                    foreach(var c in s2)
            map[c] = map.ContainsKey(c) ? map[c]-1 : -1;
                    foreach(var v in map.Values)
            if (v!=0)
                return false;
        int length = s1.Length;
        for(int i=1; i<length; i++)
        {
            if (IsScramble(s1.Substring(0,i), s2.Substring(0,i)) 
                && IsScramble(s1.Substring(i), s2.Substring(i)))
                return true;
            if (IsScramble(s1.Substring(0,i), s2.Substring(length-i)) 
                && IsScramble(s1.Substring(i), s2.Substring(0, length-i)))
                return true;
        }
        return false;
    }
}
