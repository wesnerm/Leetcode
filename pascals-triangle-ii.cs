// 119. Pascal's Triangle II   
// https://leetcode.com/problems/pascals-triangle-ii
// Easy 36.2%
// 696.3018025723115
// Submission: https://leetcode.com/submissions/detail/70381259/
// Runtime: 416 ms
// Your runtime beats 11.94 % of csharp submissions.

public class Solution {
    public IList<int> GetRow(int rowIndex) {
        var list = Enumerable.Repeat(0, rowIndex+1).ToList();
        list[0] = 1;
        for (int i=0; i<=rowIndex; i++)
        for (int j=i; j>0; j--)
            list[j] += list[j-1];
        return list;
    }
}
