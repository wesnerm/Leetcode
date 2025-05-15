// 448. Find All Numbers Disappeared in an Array   
// https://leetcode.com/problems/find-all-numbers-disappeared-in-an-array
// Easy 52.1%
// 789.702541440835
// Submission: https://leetcode.com/submissions/detail/101896905/
// Runtime: 572 ms
// Your runtime beats 57.80 % of csharp submissions.

public class Solution {
    public IList<int> FindDisappearedNumbers(int[] num) {
        for (int i=0; i<num.Length; i++)
        {
            int d = num[i]-1;
            if (d != i && num[i] != num[d])
            {
                int tmp = num[i];
                num[i] = num[d];
                num[d] = tmp;
                i--;
            }
        }
                int count = 0;
        var list = new List<int>(num.Length);
        for (int i=0; i<num.Length; i++)
            if (num[i] != i+1)
                list.Add(i+1);
                        return list;
    }
}
