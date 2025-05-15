// 646. Maximum Length of Pair Chain   
// https://leetcode.com/problems/maximum-length-of-pair-chain
// Medium 46.2%
// 159.71866824297496
// Submission: https://leetcode.com/submissions/detail/111483448/
// Runtime: 265 ms
// Your runtime beats 96.49 % of csharp submissions.

public class Solution {
    public int FindLongestChain(int[,] pairs) {
                int n = pairs.GetLength(0);
        var array = new int[n][];
        for (int i=0; i<n; i++)
        {
            array[i] = new int[] { pairs[i,0], pairs[i,1]};
        }
                Array.Sort(array, (a,b)=>
                   {
                       int cmp = a[1].CompareTo(b[1]);
                       if (cmp != 0) return cmp;
                       return a[0].CompareTo(b[0]);
                   });
                long prev= long.MinValue;
        int count = 0;
                foreach(var v in array)
        {
            if (v[0] <= prev) continue;
            count++;
            prev = v[1];
        }
                return count;
    }
}
