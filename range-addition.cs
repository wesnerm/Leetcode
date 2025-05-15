// 370. Range Addition   
// https://leetcode.com/problems/range-addition
// Medium 54.8%
// 273.1497267059317
// Submission: https://leetcode.com/submissions/detail/68233826/
// Runtime: 598 ms
// Your runtime beats 9.09 % of csharp submissions.

public class Solution {
    public int[] GetModifiedArray(int length, int[,] updates) {
        int ulen = updates.GetLength(0);
        int[] diffs = new int[length+1];
                for(int i=0; i<ulen; i++)
        {
            int si = updates[i,0];
            int ei = updates[i,1];
            int data = updates[i,2];
                        diffs[si] += data;
            diffs[ei+1] -= data;
        }
                int sum = 0;
        int [] result = new int[length];
        for (int i=0; i<length; i++)
        {
            sum+=diffs[i];
            result[i] = sum;
        }
                return result;
    }
}
