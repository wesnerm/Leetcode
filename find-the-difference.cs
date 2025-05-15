// 389. Find the Difference   
// https://leetcode.com/problems/find-the-difference
// Easy 51.5%
// 693.5190863687349
// Submission: https://leetcode.com/submissions/detail/72084021/
// Runtime: 132 ms
// Your runtime beats 17.05 % of csharp submissions.

public class Solution {
    public char FindTheDifference(string s, string t) {
        int [] letters = new int[26];
                foreach (var ch in s)
            letters[ch-'a']++;
                    foreach (var ch in t)
            if (letters[ch-'a']-- == 0)
                return ch;
                        return '\0';
    }
}
