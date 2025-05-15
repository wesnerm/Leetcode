// 231. Power of Two   
// https://leetcode.com/problems/power-of-two
// Easy 39.9%
// 865.105051609261
// Submission: https://leetcode.com/submissions/detail/67729009/
// Runtime: 60 ms
// Your runtime beats 15.38 % of csharp submissions.

public class Solution {
    public bool IsPowerOfTwo(int n) {
        return n > 0 && (n&n-1)==0;
/*        int v = n;
        while (v > 1)
        {
            if (v % 2 != 0)
                return false;
            v /= 2;
        }
        return v == 1;
        */
    }
}
