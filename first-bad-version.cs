// 278. First Bad Version   
// https://leetcode.com/problems/first-bad-version
// Easy 24.9%
// 795.9677680115115
// Submission: https://leetcode.com/submissions/detail/70452016/
// Runtime: 56 ms
// Your runtime beats 13.77 % of csharp submissions.

/* The isBadVersion API is defined in the parent class VersionControl.
      bool IsBadVersion(int version); */
public class Solution : VersionControl {
    public int FirstBadVersion(int n) {
        int left = 0;
        int right = n;
        while (left<=right)
        {
            int mid = left + (right-left)/2;
            if (IsBadVersion(mid))
                right = mid-1;
            else
                left = mid+1;
        }
                return left;
    }
}
