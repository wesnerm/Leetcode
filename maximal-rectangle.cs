// 85. Maximal Rectangle   
// https://leetcode.com/problems/maximal-rectangle
// Hard 27.2%
// 1013.7125326875007
// Submission: https://leetcode.com/submissions/detail/71163504/
// Runtime: 184 ms
// Your runtime beats 33.33 % of csharp submissions.

public class Solution {
    public int MaximalRectangle2(char[,] matrix) {
        int m = matrix.GetLength(0);
        int n = matrix.GetLength(1);
        int[] h = new int[n];
        int maxarea = 0;
        for (int i=0; i<m; i++)
        {
            for (int j=0; j<n; j++)
                h[j] = matrix[i,j]=='1' ? h[j]+1 : 0;
            maxarea = Math.Max(maxarea, LargestArea(h));
        }
        return maxarea;
    }
        public int LargestArea(int[] heights)
    {
        int maxarea = 0;
        var stack = new Stack<int>();
                for (int i=0; i<=heights.Length; )
        {
            int h = i<heights.Length ? heights[i] : 0;
            if (stack.Count==0 || heights[stack.Peek()] < h)
            {
                stack.Push(i++);
                continue;
            }
            int h2 = heights[stack.Pop()];
            int left = stack.Count>0 ? stack.Peek()+1 : 0;
            int area = (i-left) * h2;
            maxarea= Math.Max(maxarea, area);
        }
                return maxarea;
    }
        public int MaximalRectangle(char[,] matrix)
    {
        int m = matrix.GetLength(0);
        int n = matrix.GetLength(1);
        int[] left = new int[n];
        int[] right = new int[n];
        int[] height = new int[n];
                for (int i=0; i<right.Length; i++)
            left[i] = right[i] = n;
                int maxarea = 0;
        for(int i=0; i<m; i++)
        {
            int dist = 0;
            for(int j=0; j<n; j++) 
            { 
                if(matrix[i,j]=='1') 
                    left[j]=Math.Min(left[j],++dist);
                else 
                    {left[j]=n; dist=0;}
            }
            dist = 0;
            for(int j=n-1; j>=0; j--)
            {
                if(matrix[i,j]=='1') 
                    right[j]=Math.Min(right[j],++dist);
                else 
                    {right[j]=n; dist=0;}    
            }
                        // compute the area of rectangle
            for(int j=0; j<n; j++)
            {
                height[j] = matrix[i,j]=='1' ? height[j]+1 : 0;
                maxarea = Math.Max(maxarea,(right[j]+left[j]-1)*height[j]);
            }
        }
        return maxarea;
   }
   }
