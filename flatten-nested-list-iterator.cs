// 341. Flatten Nested List Iterator   
// https://leetcode.com/problems/flatten-nested-list-iterator
// Medium 40.7%
// 696.2507299498816
// Submission: https://leetcode.com/submissions/detail/68517279/
// Runtime: 508 ms
// Your runtime beats 11.11 % of csharp submissions.

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
public class NestedIterator {
    public Stack<IEnumerator<NestedInteger>> stack;
    public bool moved;
    public bool eof;
    public int next;
    public NestedIterator(IList<NestedInteger> nestedList) {
        stack = new Stack<IEnumerator<NestedInteger>>();
        stack.Push(nestedList.GetEnumerator());
    }
    public bool HasNext() {
        Move();
        return !eof;
    }
    public int Next() {
        Move();
        moved = false;
        return next;        
    }
            private void Move()
    {
        if (moved)
            return;
                moved = true;
                while (stack.Count > 0)
        {        
            var peek = stack.Peek();
            if (peek.MoveNext())
            {
                var current = peek.Current;
                if (current.IsInteger())
                {
                    next = current.GetInteger();
                    return;
                }
                stack.Push(current.GetList().GetEnumerator());
            }
            else
            {
                stack.Pop();
            }
        }
                eof = true;
    }
}
/**
 * Your NestedIterator will be called like this:
 * NestedIterator i = new NestedIterator(nestedList);
 * while (i.HasNext()) v[f()] = i.Next();
 */
