// 49. Group Anagrams   
// https://leetcode.com/problems/group-anagrams
// Medium 33.6%
// 1089.341714141055
// Submission: https://leetcode.com/submissions/detail/68947430/
// Runtime: 524 ms
// Your runtime beats 75.83 % of csharp submissions.

public class Solution {
    public IList<IList<string>> GroupAnagrams(string[] strs) {
        var hash = new Dictionary<string, IList<string>>();
        foreach(var s in strs)
        {
            var c = Canonicalize(s);
            if (!hash.ContainsKey(c))
                hash[c] = new List<string>();
            hash[c].Add(s);
        }
                return hash.Values.ToList();
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
