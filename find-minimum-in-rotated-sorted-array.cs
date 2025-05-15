// 153. Find Minimum in Rotated Sorted Array   
// https://leetcode.com/problems/find-minimum-in-rotated-sorted-array
// Medium 39.5%
// 1104.5642061454726
// Submission: https://leetcode.com/submissions/detail/69761412/
// Runtime: 176 ms
// Your runtime beats 7.14 % of csharp submissions.

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
