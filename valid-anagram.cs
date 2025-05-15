// 242. Valid Anagram   
// https://leetcode.com/problems/valid-anagram
// Easy 46.0%
// 1033.5590316014723
// Submission: https://leetcode.com/submissions/detail/68946813/
// Runtime: 188 ms
// Your runtime beats 7.90 % of csharp submissions.

public class Solution 
{
    public bool IsAnagram(string s, string t) 
    {
        return Canonicalize(s) == Canonicalize(t);
    }
    public static string Canonicalize(string s)
    {
        if (s==null)
            return null;
        var array = s.ToCharArray();
        Array.Sort(array);
        return new string(array);
    }
}
