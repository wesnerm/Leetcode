// 297. Serialize and Deserialize Binary Tree   
// https://leetcode.com/problems/serialize-and-deserialize-binary-tree
// Hard 32.8%
// 804.485522748783
// Submission: https://leetcode.com/submissions/detail/68416315/
// Runtime: 201 ms
// Your runtime beats 35.64 % of csharp submissions.

/**
 * Definition for a binary tree node.
 * public class TreeNode {
 *     public int val;
 *     public TreeNode left;
 *     public TreeNode right;
 *     public TreeNode(int x) { val = x; }
 * }
 */
    public class Codec
    {
        // Encodes a tree to a single string.
        public string serialize(TreeNode root)
        {
            var sb = new StringBuilder();
            ser(sb, root);
            return sb.ToString();
        }
        void ser(StringBuilder sb, TreeNode root)
        {
            if (root == null)
            {
                sb.Append("X");
                return;
            }
            sb.Append(root.val);
            sb.Append(",");
            ser(sb,root.left);
            sb.Append(",");
            ser(sb,root.right);
        }
        // Decodes your encoded data to tree.
        public TreeNode deserialize(string data)
        {
            int index = 0;
            return des(data, ref index);
        }
        TreeNode des(string data, ref int index)
        {
            if (data[index] == 'X')
            {
                index++;
                return null;
            }
            int i = data.IndexOf(',', index);
            var node = new TreeNode(int.Parse(data.Substring(index, i - index)));
            index = i + 1;
            node.left = des(data, ref index);
            index++; // skip over comma
            node.right = des(data, ref index);
            return node;
        }
    }
// Your Codec object will be instantiated and called as such:
// Codec codec = new Codec();
// codec.deserialize(codec.serialize(root));
