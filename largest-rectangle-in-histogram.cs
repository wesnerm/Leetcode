// 84. Largest Rectangle in Histogram   
// https://leetcode.com/problems/largest-rectangle-in-histogram
// Hard 26.3%
// 710.5952736143233
// Submission: https://leetcode.com/submissions/detail/70695598/
// Runtime: 192 ms
// Your runtime beats 16.18 % of csharp submissions.

public class Solution {
    public int LargestRectangleArea2(int[] heights) {
        var stack = new Stack<int>();
        int maxarea = 0;
        // increasing stack...
        for (int i=0; i<heights.Length+1; )
        {
            int h = i<heights.Length ? heights[i] : 0;
            if (stack.Count == 0 || heights[stack.Peek()]<h)
                stack.Push(i++);
            else
            {
                var pop = stack.Pop();
                int left = stack.Count==0? 0 : stack.Peek()+1;
                // we found the largest area spanned by heights[pop]
                int area = heights[pop] * (i - left);
                maxarea = Math.Max(maxarea, area);
            }
        }
                        return maxarea;
    }
        public int LargestRectangleArea(int [] heights)
    {
        return LargestRectangleArea(heights, 0, heights.Length-1);
    }
        public int LargestRectangleArea(int [] heights, int left, int right)
    {
        if (left>right)
            return 0;
                if (left==right)
            return heights[left];
                int mid = (left + right)/2;
                int leftmax = LargestRectangleArea(heights, left, mid);
        int rightmax = LargestRectangleArea(heights, mid+1, right);
                int lt = mid;
        int rt = mid+1;
        int max = Math.Max(leftmax, rightmax);
                int h = int.MaxValue;
        while (lt>=left && rt<=right)
        {
            h = Math.Min(h, Math.Min(heights[lt], heights[rt]));
            max = Math.Max(max, h * (rt-lt+1));
            if (rt>=right || lt > left && heights[lt-1]>=heights[rt+1])
                lt--;
            else
                rt++;
        }
                return max;        
    }
    }
