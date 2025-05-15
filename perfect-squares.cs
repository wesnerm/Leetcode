// 279. Perfect Squares    
// https://leetcode.com/problems/perfect-squares
// Medium 36.2%
// 859.8133118322506
// Submission: https://leetcode.com/submissions/detail/71743500/
// Runtime: 64 ms
// Your runtime beats 98.41 % of csharp submissions.

public class Solution {
        static int[] perfectCounts = new int[100];
    public int NumSquares(int n) {
        if (n<=0)
            return 0;
        if (n+2 > perfectCounts.Length)
            Array.Resize(ref perfectCounts, n+2);
        int sqrtn = (int)Math.Sqrt(n);
        var perfectSquares = new List<int>(sqrtn);
        for (int j=1; j<=sqrtn; j++)
        {
            perfectSquares.Add(j*j);
            perfectCounts[j*j] = 1;
        }
        foreach(var i1 in perfectSquares)
            foreach(var i2 in perfectSquares)
            {
                int sum = i1+i2;
                if (sum<perfectCounts.Length && perfectCounts[sum] == 0)
                    perfectCounts[sum] = 2;
            }
        if (perfectCounts[n] != 0)
            return perfectCounts[n];
                    for (int i=1; i<=n; i++)
            if (perfectCounts[i] == 0)
            {
                int min = int.MaxValue;
                for (int j=1; j*j<=i; j++)
                    min = Math.Min( 1+perfectCounts[i-j*j], min);
                perfectCounts[i]=min;
            }
        return perfectCounts[n];
    }
}
