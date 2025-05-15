// 35. Search Insert Position   
// https://leetcode.com/problems/search-insert-position
// Easy 39.5%
// 671.041777732365
// Submission: https://leetcode.com/submissions/detail/70452550/
// Runtime: 152 ms
// Your runtime beats 25.14 % of csharp submissions.

public class Solution {
    public int SearchInsert(int[] nums, int target) {
        int left= 0;
        int right=nums.Length-1;
                while (left<=right)
        {
            int mid = left + (right-left)/2;
            if (target <= nums[mid])
                right = mid-1;
            else
                left = mid+1;
        }
                return left;
    }
}
