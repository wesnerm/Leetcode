// 169. Majority Element   
// https://leetcode.com/problems/majority-element
// Easy 46.1%
// 1445.8567387029643
// Submission: https://leetcode.com/submissions/detail/70029797/
// Runtime: 168 ms
// Your runtime beats 85.79 % of csharp submissions.

public class Solution {
    public int MajorityElement(int[] nums) {
        int major = 0;
        int count = 0;
                foreach(var n in nums)
        {
            if (count == 0)
                major = n;
            if (major == n)
                count++;
            else
                count--;
        }
                return major;
    }
}
