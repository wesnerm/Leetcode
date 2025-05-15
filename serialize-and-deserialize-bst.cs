// 449. Serialize and Deserialize BST   
// https://leetcode.com/problems/serialize-and-deserialize-bst
// Medium 41.9%
// 460.12283034625494
// Submission: https://leetcode.com/submissions/detail/92189228/
// Runtime: 172 ms
// Your runtime beats 75.76 % of csharp submissions.

/**
 * Definition for a binary tree node.
 * public class TreeNode {
 *     public int val;
 *     public TreeNode left;
 *     public TreeNode right;
 *     public TreeNode(int x) { val = x; }
 * }
 */
public class Codec {
    // Encodes a tree to a single string.
    public string serialize(TreeNode root) {
        var sb = new StringBuilder();
        serialize(sb, root);
        return sb.ToString();
    }
    public void serialize(StringBuilder sb, TreeNode root)
    {
        if (root==null) { sb.Append("x"); return; }
        sb.Append(root.val);
        sb.Append(",");
        serialize(sb, root.left);
        sb.Append(",");
        serialize(sb, root.right);
    }
    // Decodes your encoded data to tree.
    public TreeNode deserialize(string data) {
        int i = 0;
        //Console.WriteLine($"Deserializing '{data}'");
        return deserialize(data, ref i);
    }
        public TreeNode deserialize(string data, ref int i)
    {
        if (data[i]=='x') 
        {
            i++;
            return null;
        }
                int start = i;
        while (i<data.Length && data[i]!=',') i++;
        var s = data.Substring(start, i-start);
        //Console.WriteLine($"Parsing '{s}'");
        var val = int.Parse(s);                
        i++;
        var left = deserialize(data, ref i);
        i++;
        var right = deserialize(data, ref i);
        return new TreeNode(val) { left=left, right=right };        
    }
}
// Your Codec object will be instantiated and called as such:
// Codec codec = new Codec();
// codec.deserialize(codec.serialize(root));
