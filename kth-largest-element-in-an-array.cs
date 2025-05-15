// 215. Kth Largest Element in an Array   
// https://leetcode.com/problems/kth-largest-element-in-an-array
// Medium 38.7%
// 780.7104439116848
// Submission: https://leetcode.com/submissions/detail/68102049/
// Runtime: 152 ms
// Your runtime beats 72.73 % of csharp submissions.

public class Solution {
        public  int FindKthLargest(int[] nums, int k)
        {
            int lo = 0;
            int hi = nums.Length - 1;
            int pos = nums.Length - k;
            while (lo < hi)
            {
                int index = Partition(nums, lo, hi);
                if (pos < index)
                    hi = index - 1;
                else if (pos > index)
                    lo = index + 1;
                else
                    break;
            }
            return nums[pos];
        }
        public  int Partition(int[] nums, int rangeStart, int rangeEnd)
        {
            int index = rangeStart + (rangeEnd-rangeStart+1)/2;
            int start = rangeStart+1;
            int end = rangeEnd;
            int median = nums[index];
            nums[index] = nums[rangeStart];
            while (start <= end)
            {
                while (start <= end && nums[start] <= median) start++;
                while (start <= end && nums[end] > median) end--;
                if (start < end)
                {
                    int tmp = nums[start];
                    nums[start++] = nums[end];
                    nums[end--] = tmp;
                }
            }
            int pivotLoc = start - 1;
            nums[rangeStart] = nums[pivotLoc];
            nums[pivotLoc] = median;
            return pivotLoc;
        }
    }
