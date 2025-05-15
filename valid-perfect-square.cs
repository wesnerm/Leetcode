// 367. Valid Perfect Square   
// https://leetcode.com/problems/valid-perfect-square
// Easy 38.0%
// 431.6454748575614
// Submission: https://leetcode.com/submissions/detail/70823562/
// Runtime: 48 ms
// Your runtime beats 56.45 % of csharp submissions.

public class Solution {
    // Binary Search O(lg n)
        // Summing Odd Numbers O(sqrt(n))
    public bool IsPerfectSquare2(int num) {
        if (num < 0)
            return false;
                    int i=1;
        long sum=0;
        while (sum<num)
        {
            sum += i;
            i+=2;
        }
        return sum==num;
    }
            // Newton - close to constant
    public bool IsPerfectSquare(int num) 
    {
        int sqrt = Sqrt(num);
        return sqrt*sqrt == num;
    }
        int Sqrt(int x)
    {
        if (x<=0) return 0;
                // Use long variable to prevent overflow
        // Initialize to x to handle the case of 1
                long sqrt = x;
        while (sqrt*sqrt>x)
            sqrt = (sqrt + x/sqrt)/2;
        return (int)sqrt; 
    }
        }
