// 461. Hamming Distance   
// https://leetcode.com/problems/hamming-distance
// Easy 70.3%
// 1439.5790095690143
// Submission: https://leetcode.com/submissions/detail/101892105/
// Runtime: 52 ms
// Your runtime beats 32.30 % of csharp submissions.

public class Solution {
    public int HammingDistance(int x, int y) {
        long xy = (uint)x^(uint)y;
        int count = 0;
        while (xy>0)
        {
            xy &= xy-1;
            count++;
        }
        return count;
    }
}
