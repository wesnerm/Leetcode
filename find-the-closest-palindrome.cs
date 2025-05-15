// 564. Find the Closest Palindrome   
// https://leetcode.com/problems/find-the-closest-palindrome
// Hard 16.3%
// 259.784079185925
// Submission: https://leetcode.com/submissions/detail/105459607/
// Runtime: 136 ms
// Your runtime beats 50.00 % of csharp submissions.

using System.Text;
using System;
using static System.Math;
public class Solution {
    public string NearestPalindromic(string n) {
        long v = long.Parse(n);
                if (v==0) return "1";
        if (v<11) return (v-1).ToString();
                        var list = new List<long>();
                var sb = new StringBuilder(n);
        int left = 0;
        int right = sb.Length-1;
        while (left<right)
            sb[right--] = sb[left++];
        for (; right<sb.Length; right++, left--)
        {
            if (right<left) continue;
            var ch = sb[right];
            if (ch<'9')
            {
                sb[left] = sb[right] = (char)(ch+1);
                list.Add(long.Parse(sb.ToString()));
            }
            if (ch>'0')
            {
                sb[left] = sb[right] = (char)(ch-1);
                list.Add(long.Parse(sb.ToString()));
            }
                        sb[left] = sb[right] = ch;
        }
        list.Add(long.Parse(sb.ToString()));
        if (n.Length>=2)
        {
            var prev = (char)(n[0]-1);
            string alt = prev + new string('9', n.Length-2) + prev;
            list.Add(long.Parse(alt));
            list.Add(long.Parse(new string('9', n.Length)));
            list.Add(long.Parse(new string('9', n.Length-1)));
            list.Add(long.Parse('1' + new string('0', n.Length-1) + '1'));
            if (n.Length>2) list.Add(long.Parse(new string('9', n.Length-2)));
        }
                list.RemoveAll(x=>x==v);
        list.Sort((a,b)=>
        {
           int cmp = Abs(a-v).CompareTo((Abs(b-v)));
           if (cmp!=0) return cmp;
           return a.CompareTo(b); 
        });
        return list[0].ToString();
    }
}
