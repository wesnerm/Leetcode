// 42. Trapping Rain Water   
// https://leetcode.com/problems/trapping-rain-water
// Hard 36.3%
// 1261.0673179948587
// Submission: https://leetcode.com/submissions/detail/67558591/
// Runtime: 164 ms
// Your runtime beats 22.76 % of csharp submissions.

public class Solution {
    public int Trap(int[] height) {
        int water = 0;
        int level = 0;
                int left = 0;
        int right = height.Length -1;
                while (left <= right)
        {
            int leftHeight = height[left];
            int rightHeight = height[right];
                        int current = Math.Min(leftHeight, rightHeight);
            level = Math.Max(level, current);
            if (leftHeight <= rightHeight)
            {
                water += level - leftHeight;
                left++;
            }
            else
            {
                water += level - rightHeight; 
                right--;                
            }
        }
                return water;
    }
}
