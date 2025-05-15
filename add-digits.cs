// 258. Add Digits   
// https://leetcode.com/problems/add-digits
// Easy 50.9%
// 1401.8466747108234
// Submission: https://leetcode.com/submissions/detail/70005082/
// Runtime: 60 ms
// Your runtime beats 16.52 % of csharp submissions.

public class Solution {
    public int AddDigits(int num) {
    /*    while (num>9)
        {
            int newNum = 0;
            while (num > 0)
            {
                newNum += num % 10;
                num /= 10;
            }
            num = newNum;
        }
        return num; */
        int res = num % 9;
        return res==0 ? (num > 0 ? 9 : 0) : res;
    }
}
