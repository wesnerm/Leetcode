// 205. Isomorphic Strings   
// https://leetcode.com/problems/isomorphic-strings
// Easy 33.4%
// 819.22735340497
// Submission: https://leetcode.com/submissions/detail/70143745/
// Runtime: 132 ms
// Your runtime beats 23.75 % of csharp submissions.

public class Solution {
    public bool IsIsomorphic(string s, string t) {
        char[] map= new char[256];
        char[] map2 = new char[256];
                if (s.Length != t.Length)
            return false;
                    for (int i=0; i<s.Length; i++)
        {
            if (map[s[i]] == 0)
            {
                if (map2[t[i]] != 0)
                    return false;
                                    map[s[i]] = t[i];
                map2[t[i]] = s[i];
            }
                            if (map[s[i]] != t[i])
                return false;
        }
                    return true;
    }
}
