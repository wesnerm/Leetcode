// 364. Nested List Weight Sum II   
// https://leetcode.com/problems/nested-list-weight-sum-ii
// Medium 51.7%
// 404.9398078182534
// Submission: https://leetcode.com/submissions/detail/70870025/
// Runtime: 128 ms
// Your runtime beats 9.52 % of csharp submissions.

/**
 * // This is the interface that allows for creating nested lists.
 * // You should not implement it, or speculate about its implementation
 * interface NestedInteger {
 *
 *     // @return true if this NestedInteger holds a single integer, rather than a nested list.
 *     bool isInteger();
 *
 *     // @return the single integer that this NestedInteger holds, if it holds a single integer
 *     // Return null if this NestedInteger holds a nested list
 *     int getInteger();
 *
 *     // @return the nested list that this NestedInteger holds, if it holds a nested list
 *     // Return null if this NestedInteger holds a single integer
 *     IList<NestedInteger> getList();
 * }
 */
public class Solution {
    public int DepthSumInverse(IList<NestedInteger> nestedList) {
        int sum1 = 0;
        int sum2 = 0;
        var next = new List<NestedInteger>(nestedList);
                while (next.Count > 0)
        {
            var list = next;
            next = new List<NestedInteger>();
                        foreach(var item in list)
            {
                if (item.IsInteger())
                    sum1 += item.GetInteger();
                else
                    next.AddRange(item.GetList());
            }
                        sum2 += sum1;
        }
                return sum2;
    }
}
