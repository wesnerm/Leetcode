// 134. Gas Station   
// https://leetcode.com/problems/gas-station
// Medium 29.1%
// 833.464364399916
// Submission: https://leetcode.com/submissions/detail/70898792/
// Runtime: 164 ms
// Your runtime beats 18.75 % of csharp submissions.

public class Solution {
    public int CanCompleteCircuit(int[] gas, int[] cost) {
        int start = gas.Length-1;
        int end = 0;
                int fuel = gas[start]-cost[start];
        while (end<start)
        {
            if (fuel < 0)
            {
                start--;
                fuel += gas[start]-cost[start];
            }
            else
            {
                fuel += gas[end]-cost[end];
                end++;
            }
        }
                return fuel >= 0 ? start : -1;
    }
}
