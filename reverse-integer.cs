// 7. Reverse Integer   
// https://leetcode.com/problems/reverse-integer
// Easy 24.3%
// 1397.799556784823
// Submission: https://leetcode.com/submissions/detail/70137869/
// Runtime: 60 ms
// Your runtime beats 85.35 % of csharp submissions.

public class Solution {
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
