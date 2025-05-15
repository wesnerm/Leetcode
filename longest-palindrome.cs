// 409. Longest Palindrome   
// https://leetcode.com/problems/longest-palindrome
// Easy 45.2%
// 389.8616514284866
// Submission: https://leetcode.com/submissions/detail/101881399/
// Runtime: 102 ms
// Your runtime beats 89.23 % of csharp submissions.

public class Solution {
    public int LongestPalindrome(string s) 
    {
        var letters = new char[256];
        foreach(var c in s)
            letters[c]++;
            int len = 0;
        var middle = false;
        foreach(var d in letters)
        {
            if (d%2==1) middle = true;
            len += (d&~1);
        }
                if (middle)
            len ++;
        return len;
    }
}
