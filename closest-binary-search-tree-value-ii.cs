// 272. Closest Binary Search Tree Value II    
// https://leetcode.com/problems/closest-binary-search-tree-value-ii
// Hard 38.5%
// 341.5761581689177
// Submission: https://leetcode.com/submissions/detail/68231511/
// Runtime: 484 ms
// Your runtime beats 11.11 % of csharp submissions.

/**
 * Definition for a binary tree node.
 * public class TreeNode {
 *     public int val;
 *     public TreeNode left;
 *     public TreeNode right;
 *     public TreeNode(int x) { val = x; }
 * }
 */
public class Solution {
    public IList<int> ClosestKValues(TreeNode root, double target, int k)
    {
        var results = new List<int>();
        var succ = new Stack<TreeNode>();
        var pred = new Stack<TreeNode>();
        var node = root;
        while (node != null)
        {
            if (node.val > target)
            {
                succ.Push(node);
                node = node.left;
            }
            else
            {
                pred.Push(node);
                node = node.right;
            }
        }
        while (results.Count < k && succ.Count + pred.Count > 0)
        {
            if (pred.Count == 0)
                results.Add(GetSuccessor(succ));
            else if (succ.Count == 0 || Math.Abs(target - pred.Peek().val) < Math.Abs(target - succ.Peek().val))
                results.Add(GetPredecessor(pred));
            else
                results.Add(GetSuccessor(succ));
        }
        return results;
    }
    int GetPredecessor(Stack<TreeNode> st)
    {
        var pop = st.Pop();
        var p = pop.left;
        while (p != null)
        {
            st.Push(p);
            p = p.right;
        }
        return pop.val;
    }
    int GetSuccessor(Stack<TreeNode> st)
    {
        var pop = st.Pop();
        var p = pop.right;
        while (p != null)
        {
            st.Push(p);
            p = p.left;
        }
        return pop.val;
    }
    }
