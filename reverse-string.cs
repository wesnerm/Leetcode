// 344. Reverse String   
// https://leetcode.com/problems/reverse-string
// Easy 58.7%
// 2518.623716979242
// Submission: https://leetcode.com/submissions/detail/68929421/
// Runtime: 132 ms
// Your runtime beats 66.67 % of csharp submissions.

public class Solution {
    public string ReverseString(string s) {
        var sb = new StringBuilder(s);
        int left =0;
        int right = sb.Length-1;
        while (left<right)
        {
            var ch = sb[left];
            sb[left++] = sb[right];
            sb[right--] = ch;
        }
        return sb.ToString();
    }
}
