// 76. Minimum Window Substring    
// https://leetcode.com/problems/minimum-window-substring
// Hard 24.8%
// 771.0857426442385
// Submission: https://leetcode.com/submissions/detail/70638603/
// Runtime: 524 ms
// Your runtime beats 2.00 % of csharp submissions.

public class Solution {
    public string MinWindow(string s, string t) {
        var dict = new Dictionary<char, Queue<int>>();
        var count = new Dictionary<char, int>();
        var set = new SortedSet<int>();
                foreach(var c in t)
        {
            if (!count.ContainsKey(c))
            {
                dict[c] = new Queue<int>();
                count[c] = 0;                
            }
            count[c]++;
        }
                int chars = 0;
        string window = "";
        int i = -1;
        foreach(var c in s)
        {
            i++;
            if (!dict.ContainsKey(c))
                continue;
                        if (dict[c].Count < count[c])
                chars++;
            else
                set.Remove(dict[c].Dequeue());
            dict[c].Enqueue(i);
            set.Add(i);
                        if (chars == t.Length)
            {
                int newWindow = i-set.Min+1;
                if (window=="" || newWindow < window.Length)
                    window = s.Substring(set.Min, newWindow);
            }
        }
                return window;
    }
}
