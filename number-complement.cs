// 476. Number Complement   
// https://leetcode.com/problems/number-complement
// Easy 61.3%
// 726.1775682064092
// Submission: https://leetcode.com/submissions/detail/101894380/
// Runtime: 43 ms
// Your runtime beats 81.36 % of csharp submissions.

public class Solution {
    public int FindComplement(int num) {
        if (num==0) return 1;
        int hibit = HighestBit(num);
        return num ^ hibit ^ hibit-1;
    }
        public int HighestBit(int x)
    {
        while ((x & x-1) != 0)
            x &= x-1;
        return x;
    }
}
