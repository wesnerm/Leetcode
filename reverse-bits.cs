// 190. Reverse Bits   
// https://leetcode.com/problems/reverse-bits
// Easy 29.5%
// 835.8833169844695
// Submission: https://leetcode.com/submissions/detail/70450313/
// Runtime: 65 ms
// Your runtime beats 10.45 % of csharp submissions.

public class Solution {
    public uint reverseBits(uint n) {
        n = (n&0xffff0000)>>16 | (n&0x0000ffff)<<16;
        n = (n&0xff00ff00)>>8  | (n&0x00ff00ff)<<8;
        n = (n&0xf0f0f0f0)>>4  | (n&0x0f0f0f0f)<<4;
        n = (n&0xcccccccc)>>2  | (n&0x33333333)<<2;
        n = (n&0xaaaaaaaa)>>1  | (n&0x55555555)<<1;
        return n;
    }
}
