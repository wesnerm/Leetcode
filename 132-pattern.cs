// 456. 132 Pattern   
// https://leetcode.com/problems/132-pattern
// Medium 28.3%
// 342.5061415566199
// Submission: https://leetcode.com/submissions/detail/101885243/
// Runtime: 345 ms
// Your runtime beats 44.44 % of csharp submissions.

public class Solution {
    public bool Find132pattern(int[] nums) {
        var min = new int[nums.Length+1];
        min[nums.Length] = int.MaxValue;
        for (int i=nums.Length-1; i>=0; i--)
            min[i] = min[i+1] + nums[i];
        var minlist = new List<int>();
        var maxlist = new List<int>();
        foreach(var v in nums)
        {
            int left = 0;
            int right = minlist.Count-1;
            while (left<=right)
            {
                int mid = (left+right)/2;
                if (v < minlist[mid])
                    left = mid+1;
                else
                    right = mid-1;
            }
                        if (left == minlist.Count)
            {
                minlist.Add(v);
                maxlist.Add(int.MinValue);
                continue;
            }
                        if (v>minlist[left] && v<maxlist[left])
                return true;
            int j = minlist.Count;
            int m = minlist[j-1];
            while (j>0 && maxlist[j-1]<v)
            {
                j--;
                maxlist[j] = v;
                minlist[j] = m;
            }
                        /*
            if (j<minlist.Count)
            {
                maxlist.RemoveRange(j+1, maxlist.Count-(j+1));
                minlist.RemoveRange(j+1, minlist.Count-(j+1));
            }*/
        }
        /*        
        var stack = new Stack<int>();
        for (int i=nums.Length-1; i>=1; i--)
        {
            if (nums[i] > min[i-1])
            {
                            }
        }*/
                return false;
    }
}
