// 5. Longest Palindromic Substring   
// https://leetcode.com/problems/longest-palindromic-substring
// Medium 25.2%
// 1469.2888266726648
// Submission: https://leetcode.com/submissions/detail/70510145/
// Runtime: 132 ms
// Your runtime beats 97.32 % of csharp submissions.

public class Solution {
    public string LongestPalindrome(string s) {
        string maxstring = "";
        int maxlen = 0;
        for (int i=0; i<s.Length; i++)
        {
            // to eliminate even and odd cases
            // look for centers with are the same letters
                        int left = i;
            int right = i;
            while (right+1<s.Length && s[right+1]==s[left]) right++;
            i = right;
            int width = Math.Max(0,(maxlen - (right-left))/2);
            //Console.WriteLine("{0} {1} {2} {3}", width, left, right, maxlen);
                        string palindrome = GetPalindrome(s, left-width, right+width);
            if (palindrome != null)
            {
                maxstring = palindrome; 
                maxlen = palindrome.Length;
            }
        }
        return maxstring;
    }
        public string GetPalindrome(string s, int left, int right)
    {
        if (left<0 || right>=s.Length)
            return null;
                    int lt = left;
        int rt = right;
        while (lt<rt)
            if (s[lt++] != s[rt--])
                return null;
        lt = left;
        rt = right;
        while (lt>0 && rt<s.Length-1 && s[lt-1]==s[rt+1])
        {
            lt--;
            rt++;
        }
                return s.Substring(lt, rt-lt+1);
    }
    }
// Manacher Algorithm - linear time
// Gusfield's Algorithm - linear time with suffix trees
