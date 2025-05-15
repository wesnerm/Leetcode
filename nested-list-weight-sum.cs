// 339. Nested List Weight Sum   
// https://leetcode.com/problems/nested-list-weight-sum
// Easy 61.2%
// 633.4630840322886
// Submission: https://leetcode.com/submissions/detail/70006284/
// Runtime: 124 ms
// Your runtime beats 4.00 % of csharp submissions.

/**
 * // This is the interface that allows for creating nested lists.
 * // You should not implement it, or speculate about its implementation
 * interface NestedInteger {
 *
 *     // @return true if this NestedInteger holds a single integer, rather than a nested list.
 *     bool IsInteger();
 *
 *     // @return the single integer that this NestedInteger holds, if it holds a single integer
 *     // Return null if this NestedInteger holds a nested list
 *     int GetInteger();
 *
 *     // @return the nested list that this NestedInteger holds, if it holds a nested list
 *     // Return null if this NestedInteger holds a single integer
 *     IList<NestedInteger> GetList();
 * }
 */
public class Solution {
    public int DepthSum(IList<NestedInteger> nestedList, int depth=1) {
        int sum = 0;
        foreach(var item in nestedList)
        {
            if (item.IsInteger())
                sum += item.GetInteger()*depth;
            else
                sum += DepthSum(item.GetList(), depth+1);
        }
        return sum;
    }
    }
