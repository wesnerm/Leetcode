// 605. Can Place Flowers   New
// https://leetcode.com/problems/can-place-flowers
// Easy 30.2%
// 182.04045480504885
// Submission: https://leetcode.com/submissions/detail/105463583/
// Runtime: 162 ms
// Your runtime beats 82.72 % of csharp submissions.

public class Solution {
    public bool CanPlaceFlowers(int[] flowerbed, int n) {
        int k = 0;
                for (int i=0; i<flowerbed.Length; i++)
        {
            if (flowerbed[i]==1 || i>0 && flowerbed[i-1]==1 || i+1<flowerbed.Length && flowerbed[i+1]==1)
                continue;
                            flowerbed[i] = 1;
            k++;
        }
            return k>=n;
    }
}
