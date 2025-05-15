// 405. Convert a Number to Hexadecimal   
// https://leetcode.com/problems/convert-a-number-to-hexadecimal
// Easy 40.9%
// 305.77473063135153
// Submission: https://leetcode.com/submissions/detail/75871222/
// Runtime: 45 ms
// Your runtime beats 100.00 % of csharp submissions.

public class Solution {
    public string ToHex(int v) {
        long num = v>=0 ? v : (long)(uint)v;
        var s = new StringBuilder();
        while (num>0)
        {
            var digit = num & 0xf;
            if (digit<10) s.Insert(0,(char)(digit+'0'));
            else s.Insert(0,(char)(digit-10+'a'));
            num >>= 4;
        }
        if (s.Length==0) s.Append('0');
        return s.ToString();
    }
}
