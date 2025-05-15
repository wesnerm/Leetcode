// 135. Candy   
// https://leetcode.com/problems/candy
// Hard 24.4%
// 746.2624986785278
// Submission: https://leetcode.com/submissions/detail/71195838/
// Runtime: 220 ms
// Your runtime beats 20.00 % of csharp submissions.

public class Solution {
    public int Candy(int[] ratings) {
        int [] candies = new int[ratings.Length];
                candies[0] = 1;
                for (int i=1; i<candies.Length; i++)
            candies[i] = (ratings[i]>ratings[i-1]) ? candies[i-1]+1 : 1;
                for (int i=candies.Length-2; i>=0; i--)
            candies[i] = ratings[i]>ratings[i+1]
                ? Math.Max(candies[i], candies[i+1]+1)
                : candies[i];
                    return candies.Sum();
            }
}
