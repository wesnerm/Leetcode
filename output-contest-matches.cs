// 544. Output Contest Matches   
// https://leetcode.com/problems/output-contest-matches
// Medium 72.3%
// 256.2724107230149
// Submission: https://leetcode.com/submissions/detail/111727665/
// Runtime: 152 ms
// Your runtime beats 40.00 % of csharp submissions.

public class Solution {
    StringBuilder sb = new StringBuilder();
        public string FindContestMatch(int n) {
        var round = Enumerable.Range(1,n).Select(x=>new Tree { v=x }).ToList();
                while (round.Count>1)
        {
            int left = 0;
            int right = round.Count-1;
                        while (left < right)
            {
                round[left] = new Tree { l=round[left], r=round[right] };
                left++;
                right--;
            }
                        round.RemoveRange(round.Count/2, round.Count/2);
        }
        Print(round[0]);
        return sb.ToString();
    }
        void Print(Tree tree)
    {
        if( tree.v != 0)
        {
            sb.Append(tree.v);
            return;
        }
                sb.Append('(');
        Print(tree.l);
        sb.Append(',');
        Print(tree.r);
        sb.Append(')');
    }
            class Tree
    {
        public int v;
        public Tree l;
        public Tree r;
    }
}
