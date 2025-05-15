// 166. Fraction to Recurring Decimal   
// https://leetcode.com/problems/fraction-to-recurring-decimal
// Medium 17.3%
// 758.8580383294417
// Submission: https://leetcode.com/submissions/detail/68515657/
// Runtime: 72 ms
// Your runtime beats 100.00 % of csharp submissions.

public class Solution {
    public string FractionToDecimal(long numerator, long denominator) {
        var sb= new StringBuilder();
        if ((numerator<0) != (denominator<0) && numerator != 0)
            sb.Append("-");
        if (numerator<0) numerator *= -1;
        if (denominator<0) denominator *= -1;
        var w = numerator/denominator;
        sb.Append(w);
                numerator %= denominator;
        if (numerator == 0)
            return sb.ToString();
        sb.Append(".");
        while (true)
        {
            long g= gcd(numerator, denominator);
            numerator /= g;
            denominator /= g;
            if (gcd(denominator, 10) == 1)
                break;
                            numerator *= 10;
            sb.Append(numerator/denominator);
            numerator %= denominator;
        }
                if (numerator != 0)
        {
            System.Numerics.BigInteger frac=9;
            int zeros=1;
            while (frac % denominator != 0)
            {
                frac = frac*10 + 9;
                zeros++;
            }
                    sb.Append("(");    
            sb.Append((numerator * (frac/denominator)).ToString().PadLeft(zeros,'0'));
            sb.Append(")");    
        }
        return sb.ToString();
            }
        long gcd(long a, long b)
    {
        if (a==0) return b;
        if (b<a) return gcd(b,a);
        return gcd(b%a, a);
    }
    }
