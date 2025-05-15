// 204. Count Primes   
// https://leetcode.com/problems/count-primes
// Easy 26.4%
// 838.9767158136701
// Submission: https://leetcode.com/submissions/detail/69799458/
// Runtime: 144 ms
// Your runtime beats 38.18 % of csharp submissions.

public class Solution {
    public int CountPrimes(int n) {
        var isPrime = new BitArray(n, true);
        for (int i=2; i*i<n; i++)
            if (isPrime[i])
                for (int j=i*i; j<n; j+= i)
                    isPrime[j]=false;
        int count = 0;
        for (int i=2; i<n; i++)
            if (isPrime[i])
                count++;
        return count;
    }
}
