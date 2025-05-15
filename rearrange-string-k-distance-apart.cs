// 358. Rearrange String k Distance Apart   
// https://leetcode.com/problems/rearrange-string-k-distance-apart
// Hard 31.7%
// 319.19605380979027
// Submission: https://leetcode.com/submissions/detail/69781347/
// Runtime: 164 ms
// Your runtime beats 14.29 % of csharp submissions.

public class Solution {
    public string RearrangeString(string str, int k) {
        if (k<2)
            return str;
                var counts = new Dictionary<char,int>();
        foreach(var ch in str)
        {
            if (!counts.ContainsKey(ch)) counts[ch]=0;
            counts[ch]++;
        }
                var result = new StringBuilder(str.Length);
        var table = counts.Keys.ToList();
        table.Sort((a,b)=>counts[b]-counts[a]);
        while (result.Length < str.Length)
        {
            int i=0;
            for (int n = Math.Min(k, str.Length-result.Length); n>0; n--)
            {
                if (i>=table.Count) return ""; // needed to handle aa 2 to return ""
                var ch = table[i++];
                if (counts[ch]-- == 0) return ""; // need for aaabc 3 to return "" instead of abcab
                result.Append(ch);
            }
            // Small optimization
            int cnt = counts[table[0]];
            while (i<table.Count && counts[table[i]] > cnt)
            {
                var ch = table[i++];
                result.Append(ch);
                counts[ch]--;
            }
            if (i < table.Count)
            {
                cnt = counts[table[i]];
                int left=i;
                while (left>0 && counts[table[left-1]] < cnt) left--;
                                if (left < i)
                {
                    int right=i;
                    while (right+1<table.Count && counts[table[right+1]] == cnt) right++;
                        // Rotate to maintain sort order
                    Reverse(table, left, i-1);
                    Reverse(table, i, right);
                    Reverse(table, left, right);
                }
            }
        }
                return result.ToString();        
    }
    public void Reverse(IList<char> list, int lo, int hi)
    {
        while (lo < hi)
        {
            var tmp = list[lo];
            list[lo++] = list[hi];
            list[hi--] = tmp;
        }
    }
}
