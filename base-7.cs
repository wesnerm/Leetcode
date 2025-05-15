// 504. Base 7   
// https://leetcode.com/problems/base-7
// Easy 45.1%
// 297.09811439028675
// Submission: https://leetcode.com/submissions/detail/101886212/
// Runtime: 129 ms
// Your runtime beats 24.07 % of csharp submissions.

public class Solution {
    public string ConvertToBase7(long num) {
        if (num==0) return "0";
        var sb = new StringBuilder();
        var sign = num<0;
                if (sign) num = -num;
        while (num > 0)
        {
            sb.Insert(0, num%7);
            num /= 7;
        }
        if (sign) sb.Insert(0, '-');        
                return sb.ToString();
    }
}
