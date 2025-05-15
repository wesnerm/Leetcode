// 459. Repeated Substring Pattern   
// https://leetcode.com/problems/repeated-substring-pattern
// Easy 38.3%
// 365.3807635654354
// Submission: https://leetcode.com/submissions/detail/92251779/
// Runtime: 139 ms
// Your runtime beats 65.33 % of csharp submissions.

public class Solution {
    public bool RepeatedSubstringPattern(string str) {
        if (str==null || str.Length==0) return false;
                var k = KArray2(str);
        var x = k[str.Length];
        int n = str.Length;
        Console.WriteLine($"n={n} x={x}");
        return x>0 && n%(n-x) == 0;
    }
        public int[] KArray(string pat)
    {
        int[] t = new int[pat.Length];
        for (int i = 1, j = 0; i < pat.Length; i++)
        {
            while (j > 0 && pat[i] != pat[j])
                j = t[j - 1];
            t[i] = j += pat[i] == pat[j] ? 1 : 0;
        }
        return t;
    }
        public int[] KArray2(string pat)
    {
        int[] t = new int[pat.Length+1];
        t[0] = -1;
        for (int i=1, j=-1; i <= pat.Length; i++)
        {
            while (j>=0 && pat[i-1] != pat[j])
                j = t[j];
            t[i] = ++j;
        }
        return t;
    }
    }
