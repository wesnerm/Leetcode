// 264. Ugly Number II   
// https://leetcode.com/problems/ugly-number-ii
// Medium 32.2%
// 671.557392337438
// Submission: https://leetcode.com/submissions/detail/69797252/
// Runtime: 72 ms
// Your runtime beats 23.33 % of csharp submissions.

public class Solution {
    public int NthUglyNumber(int n) {
        int [] primes = new [] { 2, 3, 5 };
        int [] ugly = new int[n];
        int [] indices = new int[primes.Length];
                ugly[0] = 1;
        for (int i=1; i<ugly.Length;i++)
        {
            int next = int.MaxValue;
            for (int j=0; j<primes.Length; j++)
                next = Math.Min(next, primes[j]*ugly[indices[j]]);
            for (int j=0; j<primes.Length; j++)
                if (primes[j]*ugly[indices[j]] == next)
                    indices[j]++;
                        ugly[i] = next;
        }
                return ugly[n-1];
    }
}
