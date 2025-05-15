// 230. Kth Smallest Element in a BST   
// https://leetcode.com/problems/kth-smallest-element-in-a-bst
// Medium 43.3%
// 670.9715671326699
// Submission: https://leetcode.com/submissions/detail/68451178/
// Runtime: 164 ms
// Your runtime beats 46.67 % of csharp submissions.

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
    public int KthSmallest(TreeNode root, int k) {
        var stack = new Stack<TreeNode>();    
        Push(stack, root);
                TreeNode result = null;
        while (k>0)
        {
            result = Pop(stack);
            k--;
        }
        return result == null ? int.MaxValue : result.val;
    }
        void Push(Stack<TreeNode> stack, TreeNode node)
    {
        while (node != null)
        {
            stack.Push(node);
            node = node.left;
        }
    }
        TreeNode Pop(Stack<TreeNode> stack)
    {
        if (stack.Count==0)
            return null;
                var pop = stack.Pop();
        Push(stack, pop.right);
        return pop;
    }
    }
