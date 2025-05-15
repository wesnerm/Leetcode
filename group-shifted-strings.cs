// 249. Group Shifted Strings   
// https://leetcode.com/problems/group-shifted-strings
// Medium 40.6%
// 434.32145556892834
// Submission: https://leetcode.com/submissions/detail/68171221/
// Runtime: 480 ms
// Your runtime beats 43.75 % of csharp submissions.

public class Solution {
    public IList<IList<string>> GroupStrings(string[] strings) {
        var dict = new Dictionary<string, IList<string>>();
        foreach(var s in strings)
        {
            var c = Canonical(s);
            if (!dict.ContainsKey(c))
                dict[c] = new List<string>();
            dict[c].Add(s);
        }
        return dict.Values.ToList();
    }
        public string Canonical(string s)
    {
        if (string.IsNullOrEmpty(s))
            return s;
        int shift = 26-(s[0]-'a');
                var sb = new StringBuilder(s);
        for (int i=0; i<s.Length; i++)
            sb[i] = (char)('a' + (sb[i]-'a'+shift)%26 );
        return sb.ToString();
                }
}
