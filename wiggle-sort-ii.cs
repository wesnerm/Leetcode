// 324. Wiggle Sort II   
// https://leetcode.com/problems/wiggle-sort-ii
// Medium 25.7%
// 692.1663332280654
// Submission: https://leetcode.com/submissions/detail/68115826/
// Runtime: 564 ms
// Your runtime beats 36.36 % of csharp submissions.

public class Solution 
{
         int[] a;
            public void WiggleSort(int[] nums)
            {
                a = nums;
                Array.Sort(nums);
                Array.Reverse(nums);
                int len = nums.Length;
                int pivot = nums[len / 2];
                int left = 0;
                int right = len - 1;
                for (int i = 0; i <= right;)
                {
                    var ai = A(i);
                    if (ai > pivot)
                        Swap(left++, i++);
                    else if (ai < pivot)
                        Swap(right--, i);
                    else
                        i++;
                }
            }
            private void Swap(int index1, int index2)
            {
                int i1 = VirtualIndex(index1);
                int i2 = VirtualIndex(index2);
                int tmp = a[i1];
                a[i1] = a[i2];
                a[i2] = tmp;
            }
            private int A(int index)
            {
                return a[VirtualIndex(index)];
            }
            private int VirtualIndex(int index)
            {
                return (1 + 2 * index) % (a.Length | 1);
            }
    }
