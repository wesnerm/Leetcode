// 536. Construct Binary Tree from String   
// https://leetcode.com/problems/construct-binary-tree-from-string
// Medium 39.2%
// 141.353670086344
// Submission: https://leetcode.com/submissions/detail/105460132/
// Runtime: 126 ms
// Your runtime beats 81.82 % of csharp submissions.

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
    public TreeNode Str2tree(string s) {
        int index = 0;
        return Parse(s, ref index);
    }
        public TreeNode Parse(string s, ref int index)
    {
        if (index>=s.Length) return null;
        int  sign = 1;
        if (s[index]=='-') 
        {
            sign=-1;
            index++;
        }
        int number = 0;
        while (index<s.Length && s[index]>='0' && s[index]<='9')
            number = number*10 + s[index++] - '0';
        number *= sign;
                return new TreeNode(number)
        {
            left = Parse2(s, ref index),
            right = Parse2(s, ref index),
        };
    }
        public TreeNode Parse2(string s, ref int index)
    {
        if (index<s.Length && s[index]=='(')
        {
            index++;
            var result = Parse(s, ref index);
            index++;
            return result;
        }
        return null;
    }
    }
