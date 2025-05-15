// 9. Palindrome Number   
// https://leetcode.com/problems/palindrome-number
// Easy 35.2%
// 1365.8436247880509
// Submission: https://leetcode.com/submissions/detail/70138151/
// Runtime: 180 ms
// Your runtime beats 2.96 % of csharp submissions.

public class Solution {
    public bool IsPalindrome(int x) {
            return x>=0 && Reverse(x) == x;    
    }
        public int Reverse(int x) {
        long result = Reverse((long)x);
        if (result > int.MaxValue || result < int.MinValue)
            return 0;
        return (int) result;
   }
        public long Reverse(long x) {
        if (x < 0) return -Reverse(-x);
                long result = 0;
        while (x > 0)
        {
            result = result*10 + (x%10);
            x/=10;
        }
                return result;
    }
}
