// 483. Smallest Good Base   
// https://leetcode.com/problems/smallest-good-base
// Hard 31.3%
// 226.04151632025852
// Submission: https://leetcode.com/submissions/detail/101886008/
// Runtime: 652 ms
// Your runtime beats 33.33 % of csharp submissions.

public class Solution {
            public string SmallestGoodBase(string nParam) {
        long n = long.Parse(nParam);
        if (IsPrimeMillerRabin(n-1))
            return (n-1).ToString();
                var factors = PrimeFactors(n-1);
        var list = factors.Keys.ToList();
        var allfactors = new List<long>();
        Dfs(factors, list, allfactors, 0, 1L);
        allfactors.Sort();
                foreach(var f in allfactors)
        {
            Console.WriteLine(f);
            bool good = true;
            for (long n2=n; n2>0; n2/=f)
            {
                if ( n2 % f != 1)
                {
                    good = false;
                    break;
                }
            }
            if (good) return f.ToString();            
        }
                return (n-1).ToString();
    }
        void Dfs(Dictionary<long, int> factors, List<long> list, List<long> result, int index, long v)
    {
        if (index==list.Count)
        {
            result.Add(v);
            return;
        }
        var f = list[index];        
        var c = factors[f];
        var factor = v;
        for (int i=0; i<=c; i++)
        {
            Dfs(factors, list, result, index+1, v);
            v*=f;
        }
    }
                    public static Dictionary<long, int> PrimeFactors(long n)
        {
            var dict = new Dictionary<long, int>();
            if (IsPrimeMillerRabin(n))
                return dict;
            int cnt = 0;
            while (n % 2 == 0)
            {
                n /= 2;
                cnt++;
            }
            if (cnt > 0)
                dict[2] = cnt;
            for (long i = 3; i * i <= n; i += 2)
            {
                cnt = 0;
                while (n % i == 0)
                {
                    n /= i;
                    cnt++;
                }
                if (cnt > 0)
                    dict[i] = cnt;
            }
            if (n != 1)
                dict[n] = 1;
            return dict;
        }
            private const long PrimesUnder64 = 0
            | 1L << 02 | 1L << 03 | 1L << 05 | 1L << 07
            | 1L << 11 | 1L << 13 | 1L << 17 | 1L << 19
            | 1L << 23 | 1L << 29
            | 1L << 31 | 1L << 37
            | 1L << 41 | 1L << 43 | 1L << 47
            | 1L << 53 | 1L << 59
            | 1L << 61;
        private const int PrimeFilter235 = 0
            | 1 << 1 | 1 << 7
            | 1 << 11 | 1 << 13 | 1 << 17 | 1 << 19
            | 1 << 23 | 1 << 29;
        // Witnesses must all be less that 64-2=62
        // We filter out numbers below 64
        private static readonly int[] Witness32 = { 2, 7, 61 };
        private const long Range0 = 4759123141;
        // TEST CASE: 46817 is a prime
        // Sieve is 10X faster for checking multiple primes.
        public static bool IsPrimeMillerRabin(int n)
        {
            // 2 is the first prime
            if (n < 2) return false;
            // Return primes under 64 in constant time
            // Important Step! witnesses < 64 <= n
            if (n < 64) return (PrimesUnder64 & 1L << n) != 0;
            // Filter out easy composites (3/4 of positive integers)
            if ((PrimeFilter235 & 1 << (n % 30)) == 0)
                return false;
            // Hard test
            int d = n - 1;
            while ((d & 1) == 0) { d >>= 1; }
            foreach (var w in Witness32)
            {
                // NOTE: V needs to be long because we are squaring
                long v = Pow(w, d, n);
                if (v != 1)
                {
                    for (; v != n - 1; d <<= 1)
                    {
                        if (d >= n - 1)
                            return false;
                        v = v * v % n;
                    }
                }
            }
            return true;
        }
        private static readonly int[] Witness41 = { 2, 3, 5, 7, 11, 13 };
        private static readonly int[] Witness64 = { 2, 325, 9375, 28178, 450775, 9780504, 1795265022 };
        public static bool IsPrimeMillerRabin(long n)
        {
            if (n < int.MaxValue)
                return IsPrimeMillerRabin((int)n);
            // Filter out multiples of 2, 3, and 5 (3/4 of positive integers)
            if ((PrimeFilter235 & 1 << (int)(n % 30)) == 0)
                return false;
            var witnesses = n < 3474749660383 // 41.6 bits 
                ? Witness41
                : Witness64;
            var d = n - 1;
            while ((d & 1) == 0) { d >>= 1; }
            foreach (var w in witnesses)
            {
                long v = Pow(w, d, n);
                if (v != 1)
                {
                    for (; v != n - 1; d <<= 1)
                    {
                        if (d >= n - 1)
                            return false;
                        v = Mult(v, v, n);
                    }
                }
            }
            return true;
        }
        /// <summary>
        /// Multiplication of two long values. Mod must be less than long.MaxValue
        /// </summary>
        /// <param name="a"> larger of the two factors </param>
        /// <param name="b"> smaller of the two factors (for efficiency) </param>
        /// <param name="mod"></param>
        /// <returns></returns>
        public static long Mult(long a, long b, long mod)
        {
                        return (long) ( (BigInteger) a * b % mod );
/*
            const int shift = 31;
            long result;
            if (b >= (1L << 32))
            {
                // 64 * 64 multiplication
                var bhi = b >> shift;
                var blo = b & (1L << shift) - 1;
                result = Mult(a, bhi, mod);
                result = Mult(result, 1L << shift, mod);
                result += Mult(a, blo, mod);
            }
            else if (a >= 1L << 32)
            {
                // 64 * 32 multiplication
                var ahi = a >> shift;
                var alo = a & (1L << shift) - 1;
                result = ahi * b;
                result = Mult(result, 1L << shift, mod);
                result += alo * b;      // <= 31^2 bits
            }
            else
            {
                // 32 * 32 multiplication
                result = a * b;
            }
            return result % mod; */
        }
            public static long Pow(long n, long p, long mod)
        {
            long result = 1;
            long b = n;
            while (p > 0)
            {
                if ((p & 1) == 1) result = Mult(result, b, mod);
                p >>= 1;
                b = Mult(b, b, mod);
            }
            return result;
        }
}
