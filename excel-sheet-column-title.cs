// 168. Excel Sheet Column Title   
// https://leetcode.com/problems/excel-sheet-column-title
// Easy 25.5%
// 835.1490315252888
// Submission: https://leetcode.com/submissions/detail/68819247/
// Runtime: 48 ms
// Your runtime beats 100.00 % of csharp submissions.

public class Solution {
    public string ConvertToTitle(int n) {
        var sb = new StringBuilder();
                while (n>0)
        {
            n--;
            sb.Append((char)(n%26 + 'A'));
            n /= 26;
        }
                // Reverse string
        var left = 0;
        var right = sb.Length-1;
        while(left < right)
        {
            char tmp = sb[left];
            sb[left] = sb[right];
            sb[right] = tmp;
            left++;
            right--;
        }
                return sb.ToString();
    }
}
