// 202. Happy Number   
// https://leetcode.com/problems/happy-number
// Easy 40.2%
// 1212.734346548172
// Submission: https://leetcode.com/submissions/detail/70102963/
// Runtime: 52 ms
// Your runtime beats 61.02 % of csharp submissions.

public class Solution {
    public bool IsHappy(int n) {
        int slow = n;
        int fast = n;
                while (slow != 1 && fast !=1)
        {
            slow = f(slow);
            fast = f(f(fast));
            if (slow == fast)
                return slow==1;
        }
                return true;
    }
        int f(int num)
    {
        int result = 0;
        while (num>0)
        {
            int digit = num%10;
            num /= 10;
            result += digit * digit;
        }
        return result;
    }
}
