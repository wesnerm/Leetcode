// 634. Find the Derangement of An Array   
// https://leetcode.com/problems/find-the-derangement-of-an-array
// Medium 31.5%
// 203.4430945855219
// Submission: https://leetcode.com/submissions/detail/111481194/
// Runtime: 865 ms
// Your runtime beats 14.29 % of csharp submissions.

public class Solution {
    public int FindDerangement(int n)
    {
        long sum = 0;
        long np = Fact(n);
        for (int i = n; i >= 0; i--)
        {
            long factor = np * InverseFact(i) % MOD;
            sum = factor - sum;
        }
        return (int)Fix(sum);
    }
        #region Mod Math
    public const int MOD = 1000 * 1000 * 1000 + 7;
    static int[] _inverse;
    public static long Inverse(long n)
    {
        long result;
        if (_inverse == null)
            _inverse = new int[1000001];
        if (n < _inverse.Length && (result = _inverse[n]) != 0)
            return result - 1;
        result = ModPow(n, MOD - 2);
        if (n < _inverse.Length)
            _inverse[n] = (int)(result + 1);
        return result;
    }
    public static long Mult(long left, long right)
    {
        return (left * right) % MOD;
    }
    public static long Div(long left, long divisor)
    {
        return left % divisor == 0
            ? left / divisor
            : Mult(left, Inverse(divisor));
    }
    public static long Subtract(long left, long right)
    {
        return (left + (MOD - right)) % MOD;
    }
    public static long Fix(long n)
    {
        return ((n % MOD) + MOD) % MOD;
    }
    public static long ModPow(long n, long p, long mod = MOD)
    {
        long b = n;
        long result = 1;
        while (p != 0)
        {
            if ((p & 1) != 0)
                result = (result * b) % mod;
            p >>= 1;
            b = (b * b) % mod;
        }
        return result;
    }
    public static long Pow(long n, long p)
    {
        long b = n;
        long result = 1;
        while (p != 0)
        {
            if ((p & 1) != 0)
                result *= b;
            p >>= 1;
            b *= b;
        }
        return result;
    }
    #endregion
    #region Combinatorics
    static List<long> _fact;
    static List<long> _ifact;
    public static long Fact(int n)
    {
        if (_fact == null) _fact = new List<long>(1000001) { 1 };
        for (int i = _fact.Count; i <= n; i++)
            _fact.Add(Mult(_fact[i - 1], i));
        return _fact[n];
    }
    public static long InverseFact(int n)
    {
        if (_ifact == null) _ifact = new List<long>(1000001) { 1 };
        for (int i = _ifact.Count; i <= n; i++)
            _ifact.Add(Div(_ifact[i - 1], i));
        return _ifact[n];
    }
    public static long Comb(int n, int k)
    {
        if (k <= 1) return k == 1 ? n : k == 0 ? 1 : 0;
        if (k + k > n) return Comb(n, n - k);
        return Mult(Mult(Fact(n), InverseFact(k)), InverseFact(n - k));
    }
    #endregion
        }
