// 285. Inorder Successor in BST   
// https://leetcode.com/problems/inorder-successor-in-bst
// Medium 36.0%
// 520.8972397009135
// Submission: https://leetcode.com/submissions/detail/68953778/
// Runtime: 212 ms
// Your runtime beats 8.48 % of csharp submissions.

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
            public TreeNode InorderSuccessor(TreeNode root, TreeNode p) {
        TreeNode succ = p.right;
                // Get the leftmost child of the right tree
        if (succ != null)
        {
            while (succ.left != null)
                succ=succ.left;
            return succ;
        }
        // Find lowest ancestor greater than p.val        
        while (root != null) {
            if (p.val < root.val)
            {
                succ = root;
                root = root.left;
            }
            else if (p.val > root.val)
            {
                root = root.right;
            }
            else
            {
                return root==p
                    ? succ
                    : root.left==p
                    ? p
                    : InorderSuccessor(root.left, p)
                        ?? InorderSuccessor(root.right, p)
                        ?? succ;
            }
        }
        return succ;
    }
/*
    public TreeNode InorderSuccessor(TreeNode root, TreeNode p) {
                if (p.right != null)
        {
            p=p.right;
            while (p.left != null)
                p=p.left;
            return p;
        }
            while (true)
        {
            var parent = FindParent(root, p);
            if (parent == null)
                return null;
            if (parent.left == p)
                return parent;
            if (parent.right == p)
                p = parent;
        }        
    }
        public static TreeNode FindParent(TreeNode root, TreeNode p)
    {
        if (root == null || root==p)
            return null;
                if (root.left==p || root.right==p)
            return root;
                TreeNode parent = null;
                if (root.val >= p.val)
            parent = FindParent(root.left, p);
        if (root.val <= p.val && parent == null)
            parent = FindParent(root.right, p);
        return parent;
    }
*/
}
