// 374. Guess Number Higher or Lower   
// https://leetcode.com/problems/guess-number-higher-or-lower
// Easy 34.8%
// 819.3984541364003
// Submission: https://leetcode.com/submissions/detail/67725032/
// Runtime: 0 ms
// Your runtime beats 35.91 % of cpp submissions.

// Forward declaration of guess API.
// @param num, your guess
// @return -1 if my number is lower, 1 if my number is higher, otherwise return 0
int guess(int num);
class Solution {
public:
    int guessNumber(int n) {
        long left = 1;
        long right = n;
        while (left < right)
        {
            long mid = left + (right-left)/2;
            long g = guess((int)mid);
            if (g < 0)
                right = mid-1;
            else if (g > 0)
                left = mid+1;
            else
                return (int)mid;
        }
                return (int)left;
    }
};
