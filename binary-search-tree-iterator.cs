// 173. Binary Search Tree Iterator   
// https://leetcode.com/problems/binary-search-tree-iterator
// Medium 40.6%
// 1023.9925229172502
// Submission: https://leetcode.com/submissions/detail/68029522/
// Runtime: 476 ms
// Your runtime beats 33.33 % of csharp submissions.

/**
 * Definition for binary tree
 * public class TreeNode {
 *     public int val;
 *     public TreeNode left;
 *     public TreeNode right;
 *     public TreeNode(int x) { val = x; }
 * }
 */
public class BSTIterator {
    Stack<TreeNode> stack = new Stack<TreeNode>();
    public BSTIterator(TreeNode root) {
        DescendLeftMost(root);
    }
    /** @return whether we have a next smallest number */
    public bool HasNext() {
        return stack.Count != 0;
    }
    /** @return the next smallest number */
    public int Next() {
        var node = stack.Pop();
        DescendLeftMost(node.right);
        return node.val;
    }
        private void DescendLeftMost(TreeNode node)
    {
        while (node != null)
        {
            stack.Push(node);
            node = node.left;
        }
    }
    }
/**
 * Your BSTIterator will be called like this:
 * BSTIterator i = new BSTIterator(root);
 * while (i.HasNext()) v[f()] = i.Next();
 */
