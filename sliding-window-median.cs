// 480. Sliding Window Median   
// https://leetcode.com/problems/sliding-window-median
// Hard 31.6%
// 264.68767703686945
// Submission: https://leetcode.com/submissions/detail/111705388/
// Runtime: 1619 ms
// Your runtime beats 0.00 % of csharp submissions.

using Tup = System.Tuple<double, int>;
public class Solution {
        public double[] MedianSlidingWindow(int[] nums, int k) {
        var maxheap = new SortedSet<Tup>();
        var minheap = new SortedSet<Tup>();
        var list = new List<double>();
                for (int i=0; i<nums.Length; i++)
        {
            var n = nums[i];
            var t = new Tup(n, i);
                        // Remove items
            if (i-k>=0)
            {
                var t2 = new Tup(nums[i-k], i-k);
                if (!maxheap.Remove(t2))
                    minheap.Remove(t2);
            }
                        // Add n to heap
            maxheap.Add(t);
            minheap.Add(maxheap.Min);
            maxheap.Remove(maxheap.Min);
            while (minheap.Count>maxheap.Count)
            {
                var max = minheap.Max;
                minheap.Remove(max);
                maxheap.Add(max);
            }
            //Console.WriteLine("min=" + string.Join(" ", minheap));
            //Console.WriteLine("max=" + string.Join(" ", maxheap));
            //Console.WriteLine();
                        if (minheap.Count + maxheap.Count == k) 
            {
                if (k%2==0)
                    list.Add( (minheap.Max.Item1 + maxheap.Min.Item1)/2 );
                else
                    list.Add( maxheap.Min.Item1 );
            }
        }
                return list.ToArray();
            }
                }
