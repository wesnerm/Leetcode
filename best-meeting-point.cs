// 296. Best Meeting Point   
// https://leetcode.com/problems/best-meeting-point
// Hard 51.4%
// 689.5500816508509
// Submission: https://leetcode.com/submissions/detail/71475196/
// Runtime: 180 ms
// Your runtime beats 33.33 % of csharp submissions.

public class Solution {
    public int MinTotalDistance(int[,] grid) {
        var m = grid.GetLength(0);
        var n = grid.GetLength(1);
        var rlist=new List<int>();
        var clist=new List<int>();
                for(int r=0; r<m; r++)
        for(int c=0; c<n; c++)
            if (grid[r,c]==1)
                rlist.Add(r);
        for(int c=0; c<n; c++)
        for(int r=0; r<m; r++)
            if (grid[r,c]==1)
                clist.Add(c);
        return GetMin(rlist) + GetMin(clist);
            }
        int GetMin(List<int> nums)
    {
        int left = 0;
        int right = nums.Count -1;
        int min = 0;
        while (left<right)
            min += nums[right--]-nums[left++];     
        return min;
    }
    }
