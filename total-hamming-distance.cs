// 477. Total Hamming Distance   
// https://leetcode.com/problems/total-hamming-distance
// Medium 46.2%
// 351.3270471500669
// Submission: https://leetcode.com/submissions/detail/104599052/
// Runtime: 209 ms
// Your runtime beats 61.11 % of csharp submissions.

public class Solution {
    public int TotalHammingDistance(int[] nums) {
        int count = 0;
        for (int i=0; i<31; i++)
        {
            int bitcount=0;
            foreach(var v in nums)
                if ((v & (1<<i)) != 0) bitcount++;
            count += (nums.Length-bitcount)*bitcount; 
        }
        return count;
    }
}
