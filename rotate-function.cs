// 396. Rotate Function   
// https://leetcode.com/problems/rotate-function
// Medium 31.9%
// 529.7482738224153
// Submission: https://leetcode.com/submissions/detail/74814294/
// Runtime: 262 ms
// Your runtime beats 9.09 % of csharp submissions.

using System.Dynamic;
public class Solution {
            public int MaxRotateFunction(int[] a) 
    {
        int n = a.Length;
        int sum1 = 0;
        int sumk = 0;
        for (int i=0; i<n; i++)
        {
            sum1 += a[i];
            sumk += i * a[i];
        }
        int max = sumk;
        Console.WriteLine(sumk);
        for (int i=1; i<n; i++)
        {
            sumk = sumk - sum1 + n * a[i-1];
            Console.WriteLine(sumk);
            max = Math.Max(max, sumk);
        }
        return max;
    }
}
