// 440. K-th Smallest in Lexicographical Order   
// https://leetcode.com/problems/k-th-smallest-in-lexicographical-order
// Hard 23.7%
// 470.7340459587331
// Submission: https://leetcode.com/submissions/detail/101881941/
// Runtime: 59 ms
// Your runtime beats 0.00 % of csharp submissions.

public class Solution {
        public int FindKthNumber(int n, int k, bool skip = true)
        {
            return (int) AdvanceNumber(1, n, k - 1, skip);
        }
        public long AdvanceNumber(long start, int n, int k, bool skip=false)
        {
            while (k > 0)
            {
                if (skip && TrySkip(ref start, ref n, ref k))
                    continue;
                if (start * 10 <= n)
                {
                    start *= 10;
                    k--;
                    continue;
                }
                start = Increment(start, n);
                k--;
            }
            return start;
        }
        public long Increment(long start, int n)
        {
            start ++;
            while (start > n)
                start = start / 10 + 1;
            while (start % 10 == 0)
                start /= 10;
            return start;
        }
        public bool TrySkip(ref long start, ref int n, ref int k)
        {
            int extradigits = 0;
            long lo = start;
            long hi = start;
            while (true)
            {
                lo = lo*10 + 0;
                hi = hi*10 + 9;
                if (hi>n) break;
                extradigits++;
            }
            if (extradigits == 0 || lo <= n)
                return false;
            int count = 0;
            int factor = 1;
            for (int i = 0; i <= extradigits; i++)
            {
                count += factor;
                factor *= 10;
            }
            if (k <= count)
                return false;
            k -= count;
            //start = s;
            start = Increment(start, n);
            return true;
        }
}
