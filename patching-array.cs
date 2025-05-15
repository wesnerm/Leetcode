// 330. Patching Array   
// https://leetcode.com/problems/patching-array
// Hard 31.8%
// 612.2816676653538
// Submission: https://leetcode.com/submissions/detail/69518071/
// Runtime: 176 ms
// 

public class Solution {
    public int MinPatches(int[] nums, int n) {
        long miss=1;
        int added=0;
        long i=0;
        while (miss<=n)
        {
            if (i<nums.Length && nums[i]<=miss)
            {
                miss += nums[i++];                
            }
            else
            {
                miss += miss;
                added++;
            }
        }
        return added;
    }
}
