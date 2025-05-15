// 522. Longest Uncommon Subsequence II   
// https://leetcode.com/problems/longest-uncommon-subsequence-ii
// Medium 30.0%
// 158.17711242038038
// Submission: https://leetcode.com/submissions/detail/105459771/
// Runtime: 125 ms
// Your runtime beats 100.00 % of csharp submissions.

using System.Collections.Generic;
using System.Linq;
public class Solution {
        public int FindLUSlength(string[] strs) {
        var list = strs.ToList();
        //list.Sort((a,b)=>-a.Length.CompareTo(b.Length));
        int maxlen = -1;
        for (int i=0; i<list.Count; i++)
        {
            var si = list[i];
            if (si.Length <= maxlen) continue;
            bool good = true;
            for (int j=0; j<list.Count && good; j++)
            {
                if (i!=j && IsSubsequence(si,list[j]))
                {
                    //Console.WriteLine($"{si} fails for {list[j]}");
                    good = false;
                    break;
                }
            }
            if (good)
                maxlen = si.Length;
        }
                return maxlen==0 ? -1 : maxlen;
    }
        public bool IsSubsequence(string a, string b)
    {
        if (a.Length > b.Length) return false;
                int j = 0;
        for (int i=0; i<a.Length; i++)
        {
            while (j<b.Length && b[j] != a[i]) j++;
            if (j>=b.Length) return false;
            j++;
        }
                return true; 
    }
    }
