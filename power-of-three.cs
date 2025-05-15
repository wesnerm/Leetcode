// 326. Power of Three   
// https://leetcode.com/problems/power-of-three
// Easy 39.9%
// 1094.8309908316976
// Submission: https://leetcode.com/submissions/detail/69594943/
// Runtime: 268 ms
// Your runtime beats 2.44 % of csharp submissions.

public class Solution {
    public bool IsPowerOfThree2(int n) {
                int v = n;
        while (v > 1)
        {
            if (v % 3 != 0)
                return false;
            v /= 3;
        }
        return v == 1;
    }
        public bool IsPowerOfThree(int n) 
    {
        return n > 0 && (1162261467 % n == 0);
    }
}
