// 94. Binary Tree Inorder Traversal   
// https://leetcode.com/problems/binary-tree-inorder-traversal
// Medium 45.7%
// 618.1000312099569
// Submission: https://leetcode.com/submissions/detail/68820125/
// Runtime: 524 ms
// Your runtime beats 7.18 % of csharp submissions.

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
    public IList<int> InorderTraversal(TreeNode root) {
        var stack = new Stack<TreeNode>();
        PushLeftMost(stack, root);
        TreeNode node;
        var list = new List<int>();
        while ((node = Pop(stack))!=null)
            list.Add(node.val);
        return list;
    }
        void PushLeftMost(Stack<TreeNode> stack, TreeNode root)
    {
        while (root != null)
        {
            stack.Push(root);
            root = root.left;
        }
    }
        TreeNode Pop(Stack<TreeNode> stack)
    {
        if (stack.Count==0)
            return null;
        var pop = stack.Pop();
        PushLeftMost(stack, pop.right);
        return pop;
    }
}
