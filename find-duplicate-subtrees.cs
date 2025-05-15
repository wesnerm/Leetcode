// 652. Find Duplicate Subtrees   New
// https://leetcode.com/problems/find-duplicate-subtrees
// Medium 26.4%
// 248.80718979602793
// Submission: https://leetcode.com/submissions/detail/112120633/
// Runtime: 658 ms
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
    List<TreeNode> list = new List<TreeNode>();
        public IList<TreeNode> FindDuplicateSubtrees(TreeNode root) {
        var dict = new Dictionary<TreeNode, int>(new EC());
        Core(dict, root);
        return dict.Where(x=>x.Value>1).Select(x=>x.Key).ToList();
    }
        void Core(Dictionary<TreeNode, int> dict, TreeNode node)
    {
        if (node==null) return;
                int result;
        dict.TryGetValue(node, out result);
        dict[node] = result + 1;
        Core(dict, node.left);
        Core(dict, node.right);
    }
        public class EC : IEqualityComparer<TreeNode>
    {
        public bool Equals(TreeNode t1, TreeNode t2)
        {
            if (t1==t2) return true;
            if (t1==null || t2==null) return false;
            return t1.val == t2.val && Equals(t1.left, t2.left) && Equals(t1.right, t2.right);
        }
                public int GetHashCode(TreeNode node)
        {
            if (node == null) return 0;
            long hash = node.val ^ 1234567 ;
            hash += GetHashCode(node.left) * 92364991;
            hash += GetHashCode(node.right) * 100003;
            return (int) (hash % 1000000007); 
        }
    }
    }
