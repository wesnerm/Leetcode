// 171. Excel Sheet Column Number   
// https://leetcode.com/problems/excel-sheet-column-number
// Easy 46.5%
// 1230.3966601206457
// Submission: https://leetcode.com/submissions/detail/68817413/
// Runtime: 156 ms
// Your runtime beats 5.88 % of csharp submissions.

public class Solution {
    public int TitleToNumber(string s) {
        int val = 0;
        foreach(var ch in s)
            val = 26*val + (char.ToLower(ch) - 'a' + 1);
        return val;
    }
}
