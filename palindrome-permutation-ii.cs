// 267. Palindrome Permutation II   
// https://leetcode.com/problems/palindrome-permutation-ii
// Medium 31.6%
// 333.4350625771875
// Submission: https://leetcode.com/submissions/detail/71177245/
// Runtime: 476 ms
// Your runtime beats 25.00 % of csharp submissions.

public class Solution {
    List<string> results = new List<string>();
        public IList<string> GeneratePalindromes(string s) {
        var counts = new Dictionary<char, int>();
        foreach(var c in s)
            counts[c] = counts.ContainsKey(c) ? counts[c]+1 : 1;
        var list = new List<string>();
        var chars = new char[s.Length];
        int pos=0;
        foreach(var p in counts)
        {
            var ch = p.Key;
            var count = p.Value;
                        for (int i=1; i<count; i+=2)
            {
                chars[s.Length-1-pos] = chars[pos] = ch;
                pos++;                  
            }
                        if (count % 2 == 1)
            {
                if (chars[s.Length/2] != '\0')
                    return list;
                chars[s.Length/2] = ch;
            }
        }
        Dfs(list, chars, 0);
        return list;
    }
        void Dfs(List<string> list, char[] chars, int i)
    {
        int mid = chars.Length/2;
        if (i>=mid)
        {
            list.Add(new string(chars));
            return;
        }
        char ch = chars[i];
        for (int j=i; j<mid; j++)
        {
            if (j>i && chars[j]==ch) continue;
            chars[chars.Length-1-i] = chars[i] = chars[j];
            chars[chars.Length-1-j] = chars[j] = ch;
            Dfs(list, chars, i+1);
            chars[chars.Length-1-j] = chars[j] = chars[i];
        }
        chars[chars.Length-1-i] = chars[i] = ch;
    }
}
