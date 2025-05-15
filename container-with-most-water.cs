// 11. Container With Most Water   
// https://leetcode.com/problems/container-with-most-water
// Medium 36.5%
// 1509.2778674699375
// Submission: https://leetcode.com/submissions/detail/70558582/
// Runtime: 188 ms
// Your runtime beats 42.60 % of csharp submissions.

public class Solution {
    public int MaxArea(int[] height)
    {
        int left=0;
        int right=height.Length-1;
        int maxArea = 0;
                while (left<right)
        {
            int area = (right-left) * Math.Min(height[left], height[right]);
            maxArea = Math.Max(area, maxArea);
            if (height[left] < height[right])
                left++;
            else
                right--;
        }
        return maxArea;
    }
}
