// 363. Max Sum of Rectangle No Larger Than K   
// https://leetcode.com/problems/max-sum-of-sub-matrix-no-larger-than-k
// Hard 32.6%
// 546.0436567920207
// Submission: https://leetcode.com/submissions/detail/71528998/
// Runtime: 1188 ms
// Your runtime beats 60.00 % of csharp submissions.

public class Solution {
    public int MaxSumSubmatrix(int[,] matrix, int k) {
        int m = matrix.GetLength(0);
        int n = matrix.GetLength(1);
        if (matrix.Length==0) return 0;
                int result = int.MinValue;
        var sums = new int[m];
        var set = new SortedSet<int>();
        var list = new List<int>(m);
                for (int left=0; left<n; left++)
        {
            Array.Clear(sums, 0, m);
            for (int right=left; right<n; right++)
            {
                for (int i=0; i<m; i++)
                    sums[i] += matrix[i,right];
                int curSum = 0, curMax=int.MinValue;
                // Find the max subarray no more than K
                list.Clear();
                list.Add(0);
                foreach (var sum in sums)
                {
                    curSum += sum;
                    int best = -1;
                    int target = curSum-k;
                    int i;
                    for (i=0; i<list.Count; i++)
                        if (list[i]>=target && (best<0 || list[best]>list[i]))
                            best = i;
                                        if (best>=0) curMax = Math.Max(curMax, curSum - list[best]);
                    list.Add(curSum);
                }
                /*
                set.Clear();
                set.Add(0);
                foreach (var sum in sums)
                {
                    curSum += sum;
                    var set2 = set.GetViewBetween(curSum-k, int.MaxValue);
                    if (set2.Count != 0) curMax = Math.Max(curMax, curSum - set2.Min);
                    set.Add(curSum);
                }
                */
                                result = Math.Max(result, curMax);
            }
        }
        return result;
    }
}
