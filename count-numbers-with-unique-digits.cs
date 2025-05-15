// 357. Count Numbers with Unique Digits    
// https://leetcode.com/problems/count-numbers-with-unique-digits
// Medium 45.7%
// 608.7145733545219
// Submission: https://leetcode.com/submissions/detail/68899956/
// Runtime: 48 ms
// Your runtime beats 48.72 % of csharp submissions.

public class Solution {
    public int CountNumbersWithUniqueDigits(int n) {
        if (n==0) return 1;
        if (n==1) return 10;
        if (n>10) n = 10;
                int factor = 9;
        for (int i=1; i<n; i++)
            factor *= 10-i;
        return factor + CountNumbersWithUniqueDigits(n-1);        
    }
}
