// 8. String to Integer (atoi)   
// https://leetcode.com/problems/string-to-integer-atoi
// Medium 14.0%
// 1055.9971057027274
// Submission: https://leetcode.com/submissions/detail/68815846/
// Runtime: 144 ms
// Your runtime beats 47.50 % of csharp submissions.

public class Solution {
    public int MyAtoi(string str) {
        long value = 0;
        bool started = false;
        int sign = 1;
                foreach (var ch in str)
        {
            if (!started)
            {
                if (char.IsWhiteSpace(ch)) 
                    continue;
            }
                        if (ch>='0' && ch<='9') 
            {
                started = true;
                value = value*10 + ch-'0';
                if (value > int.MaxValue)
                    break;
                continue;
            }
                        if (!started)
            {
                started = true;
                if (ch=='-')
                {
                    sign = -1;
                    continue;
                }
                if (ch=='+')
                    continue;
            }
                        break;
        }
        value *= sign;
                if (value > int.MaxValue)
            value = int.MaxValue;
        else if (value < int.MinValue) 
            value =int.MinValue;
                    return (int)value;
    }
}
