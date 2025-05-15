// 507. Perfect Number   
// https://leetcode.com/problems/perfect-number
// Easy 33.3%
// 257.8252765649447
// Submission: https://leetcode.com/submissions/detail/102248473/
// Runtime: 46 ms
// Your runtime beats 68.25 % of csharp submissions.

public class Solution {
    public bool CheckPerfectNumber(int n) {
        if (n<2) return false;
                int sum = 1;
        int sqrt = (int)Math.Ceiling(Math.Sqrt(n));
                if (sqrt > 1 && sqrt * sqrt == n)
            sum += sqrt;
        for (int i=2; i<sqrt; i++)
            if (n%i == 0)
                sum += i + n/i;
        return sum == n;
    }
}
