// 313. Super Ugly Number    
// https://leetcode.com/problems/super-ugly-number
// Medium 37.4%
// 547.4929493068522
// Submission: https://leetcode.com/submissions/detail/69797339/
// Runtime: 200 ms
// Your runtime beats 54.55 % of csharp submissions.

public class Solution {
    public int NthSuperUglyNumber(int n, int[] primes) {
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
