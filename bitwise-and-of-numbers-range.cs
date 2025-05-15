// 201. Bitwise AND of Numbers Range   
// https://leetcode.com/problems/bitwise-and-of-numbers-range
// Medium 33.7%
// 688.0436643236955
// Submission: https://leetcode.com/submissions/detail/70748041/
// Runtime: 148 ms
// 

public class Solution {
    public int RangeBitwiseAnd(int lo, int hi) {
        long highestBit = hi ^ lo;
        if (highestBit==0)
            return lo;
                while (true) 
        {
            var tmp = highestBit&(highestBit-1);
            if (tmp == 0)
                break;
            highestBit = tmp;
        }
                        return (int) (lo & hi & -highestBit); 
    }
}
