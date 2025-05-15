// 154. Find Minimum in Rotated Sorted Array II   
// https://leetcode.com/problems/find-minimum-in-rotated-sorted-array-ii
// Hard 36.8%
// 779.0973874284368
// Submission: https://leetcode.com/submissions/detail/69761204/
// Runtime: 224 ms
// Your runtime beats 2.53 % of csharp submissions.

public class Solution {
    public int FindMin(int[] num) {
        int start = 0;
        int end = num.Length-1;
                while (start < end)
        {
            int mid = (start+end)/2;
            if (num[mid] > num[end])
                start = mid +1;
            else if (num[mid] < num[end])
                end = mid;
            else
                end--;
        }
                return num[start];
    }
}
