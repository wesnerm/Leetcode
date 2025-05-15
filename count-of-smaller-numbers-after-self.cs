// 315. Count of Smaller Numbers After Self   
// https://leetcode.com/problems/count-of-smaller-numbers-after-self
// Hard 34.2%
// 741.1285934854035
// Submission: https://leetcode.com/submissions/detail/69543325/
// Runtime: 536 ms
// Your runtime beats 25.00 % of csharp submissions.

public class Solution {
    public IList<int> CountSmaller(int[] nums) {
        var counts = new int[nums.Length];
        Tree tree = null;
        for (int i=nums.Length-1; i>=0; i--)
            counts[i] = Tree.Insert(ref tree, nums[i]);
        return counts;
    }
        public class Tree
    {
        Tree left;
        Tree right;
        int value;
        int count;
        int dup;
                public static int Insert(ref Tree tree, int v)
        {
            if (tree==null)
            {
                tree = new Tree { value = v, count = 1 , dup = 1 };
                return 0;
            }
            if (v==tree.value)
                tree.dup++;
            int result = (v<tree.value)
                ? Insert(ref tree.left, v)
                : v>tree.value
                ? tree.dup + Count(tree.left) + Insert(ref tree.right, v)
                : Count(tree.left);
            tree.count = Count(tree.left) + tree.dup + Count(tree.right);
            return result;
        }
                public static int Count(Tree tree)
        {
            return tree!=null ? tree.count : 0;
        }
    }
}
