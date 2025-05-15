// 545. Boundary of Binary Tree   
// https://leetcode.com/problems/boundary-of-binary-tree
// Medium 30.9%
// 214.638487675422
// Submission: https://leetcode.com/submissions/detail/111722442/
// Runtime: 572 ms
// Your runtime beats 35.29 % of csharp submissions.

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
    List<int> result = new List<int>();
        public IList<int> BoundaryOfBinaryTree(TreeNode root) {
                    if (root != null)
        {
            result.Add(root.val);
            Boundary(root.left, -1);
            Boundary(root.right, 1);
        }
        return result;
    }
        void Boundary(TreeNode node, int dir)
    {
        if (node == null) return;
                if (node.left==null && node.right==null)
        {
            result.Add(node.val);
        }
        else
        {
            if (dir == -1) result.Add(node.val);        
            Boundary(node.left, node.right==null || dir==-1 ? dir : 0);
            Boundary(node.right, node.left==null || dir==1 ? dir :0 );
            if (dir == 1) result.Add(node.val);        
        }
    }
}
