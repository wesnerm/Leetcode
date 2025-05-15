// 263. Ugly Number   
// https://leetcode.com/problems/ugly-number
// Easy 39.0%
// 868.7031118295494
// Submission: https://leetcode.com/submissions/detail/69797573/
// Runtime: 60 ms
// Your runtime beats 12.73 % of csharp submissions.

public class Solution {
    public bool IsUgly(int num) {
        if (num == 0)
            return false;
            while (num % 2 == 0) num/=2;
        while (num % 3 == 0) num/=3;
        while (num % 5 == 0) num/=5;
        return num == 1;
    }
}
