// 336. Palindrome Pairs    
// https://leetcode.com/problems/palindrome-pairs
// Hard 25.8%
// 898.9199651223913
// Submission: https://leetcode.com/submissions/detail/69766788/
// Runtime: 640 ms
// Your runtime beats 100.00 % of csharp submissions.

public class Solution {
    public IList<IList<int>> PalindromePairs(string[] words)
    {
        var list = new List<IList<int>>();
        var dict = new Dictionary<string, int>();
        int j;
        for (int i = 0; i < words.Length; i++)
            dict[Reverse(words[i])] = i;
        for (int i = 0; i < words.Length; i++)
        {
            var w = words[i];
            for (int k = 0; k <= w.Length; k++)
            {
                if (IsPalindrome(w, k, w.Length - 1)
                    && dict.TryGetValue(w.Substring(0, k), out j) && i != j)
                    list.Add(new[] { i, j });
                if (k>0 && IsPalindrome(w, 0, k - 1)
                    && dict.TryGetValue(w.Substring(k), out j) && i !=j)
                    list.Add(new[] { j, i });
            }
        }
        return list;
    }
    public bool IsPalindrome(string s, int left, int right)
    {
        while (left < right && s[left] == s[right]) { left++; right--; }
        return left >= right;
    }
    public bool IsPalindrome(string s)
    {
        return IsPalindrome(s, 0, s.Length - 1);
    }
    public string Reverse(string s)
    {
        var rev = new StringBuilder(s);
        int left = 0;
        int right = s.Length-1;
        foreach (var ch in s)
            while (left < right)
            {
                rev[left] = s[right];
                rev[right--] = s[left++];
            }
        return rev.ToString();
    }
}
