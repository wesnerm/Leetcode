// 606. Construct String from Binary Tree   New
// https://leetcode.com/problems/construct-string-from-binary-tree
// Easy 54.0%
// 180.28121684559284
// Submission: https://leetcode.com/submissions/detail/105458403/
// Runtime: 179 ms
// Your runtime beats 91.86 % of csharp submissions.

/**
 * Definition for a binary tree node.
 * public class TreeNode {
 *     public int val;
 *     public TreeNode left;
 *     public TreeNode right;
 *     public TreeNode(int x) { val = x; }
 * }
 */
using System.Text;
 public class Solution {
        StringBuilder sb = new StringBuilder();
    public string Tree2str(TreeNode t) {
        Append(t);
        return sb.ToString();
    }
        void Append(TreeNode t)
    {
        if (t==null)
            return;
        sb.Append(t.val);
        if (t.left!= null || t.right!=null)
        {
            sb.Append('(');
            Append(t.left);
            sb.Append(')');
        }
        if (t.right != null)
        {
            sb.Append('(');
            Append(t.right);
            sb.Append(')');
        }   
    }
    }
