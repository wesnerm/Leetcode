// 541. Reverse String II   
// https://leetcode.com/problems/reverse-string-ii
// Easy 43.8%
// 298.30863619204234
// Submission: https://leetcode.com/submissions/detail/105460027/
// Runtime: 122 ms
// Your runtime beats 93.14 % of csharp submissions.

using System;
using System.Text;
public class Solution 
{
    public string ReverseStr(string s, int k) 
    {
        StringBuilder sb = new StringBuilder(s);
        for (int i=0; i<s.Length; i+=2*k)
        {
            int start = i;
            int end = Math.Min(i+k-1, s.Length-1);
            while(start<end)
            {
                char tmp = sb[start];
                sb[start++] = sb[end];
                sb[end--] = tmp;
            }
        }
        return sb.ToString();
    }
}
