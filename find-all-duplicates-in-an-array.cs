// 442. Find All Duplicates in an Array   
// https://leetcode.com/problems/find-all-duplicates-in-an-array
// Medium 54.5%
// 696.2752624548352
// Submission: https://leetcode.com/submissions/detail/101912685/
// Runtime: 595 ms
// Your runtime beats 49.23 % of csharp submissions.

public class Solution {
    public IList<int> FindDuplicates(int[] num) {
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
        var list = new HashSet<int>();
        for (int i=0; i<num.Length; i++)
            if (num[i] != i+1)
                list.Add(num[i]);
                        return list.ToList();
    }
}
