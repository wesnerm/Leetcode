// 125. Valid Palindrome   
// https://leetcode.com/problems/valid-palindrome
// Easy 26.0%
// 806.897797155561
// Submission: https://leetcode.com/submissions/detail/70144410/
// Runtime: 164 ms
// Your runtime beats 8.63 % of csharp submissions.

public class Solution {
    public bool IsPalindrome(string s) {
        int left = 0;
        int right = s.Length-1;
        while (left < right)
        {
            if (!char.IsLetterOrDigit(s[left]))
                left++;
            else if (!char.IsLetterOrDigit(s[right]))
                right--;
            else if (char.ToLower(s[left++]) != char.ToLower(s[right--]))
                return false;
        }
                return true;
    }
}
