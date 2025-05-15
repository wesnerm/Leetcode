// 229. Majority Element II   
// https://leetcode.com/problems/majority-element-ii
// Medium 28.3%
// 859.060320591545
// Submission: https://leetcode.com/submissions/detail/70141841/
// Runtime: 476 ms
// Your runtime beats 42.31 % of csharp submissions.

public class Solution {
    public IList<int> MajorityElement(int[] nums) {
        int x=0, y=0, cx=0, cy=0;
        foreach (var n in nums)
        {
            if (x == n)
                cx++;
            else if (y == n)
                cy++;
            else if (cx == 0)
            {
                x = n;
                cx++;
            }
            else if (cy == 0)
            {
                y = n;
                cy++;
            }
            else
            {
                cx--;
                cy--;
            }
        }
        cx = 0;
        cy = 0;
        foreach (var n in nums)
        {
            if (x == n)
                cx++;
            else if (y == n)
                cy++;
        }
                var list = new List<int>();
        if (cx > nums.Length/3) list.Add(x);
        if (cy > nums.Length/3) list.Add(y);
        return list;
    }
}
