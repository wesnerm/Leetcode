// 13. Roman to Integer   
// https://leetcode.com/problems/roman-to-integer
// Easy 45.5%
// 1989.4405878081961
// Submission: https://leetcode.com/submissions/detail/70094976/
// Runtime: 200 ms
// Your runtime beats 7.23 % of csharp submissions.

public class Solution {
    public int RomanToInt(string s) {
        int prev = 0;
        int result = 0;
        foreach(var c in s)
        {
            int code = RomanDigit(c);
            result += code;
            if (prev!=0 && prev<code)
                result -= prev * 2;
            prev = code;
        }
        return result;
    }
            int RomanDigit(char c)
    {
        switch( c )
        {
            case 'I': return 1;
            case 'V': return 5;
            case 'X': return 10;
            case 'L': return 50;
            case 'C': return 100;
            case 'D': return 500;
            case 'M' :  return 1000;
        }
        return 0;
    }
}
