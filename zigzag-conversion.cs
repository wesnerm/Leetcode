// 6. ZigZag Conversion   
// https://leetcode.com/problems/zigzag-conversion
// Medium 26.7%
// 1932.5681647817098
// Submission: https://leetcode.com/submissions/detail/70506587/
// Runtime: 160 ms
// Your runtime beats 78.80 % of csharp submissions.

public class Solution {
    public string Convert(string s, int numRows) {
        int r=0;
        bool up = false;
        var slist = new StringBuilder[numRows];
        for(int i=0; i<numRows; i++)
            slist[i] = new StringBuilder();
                foreach(var ch in s)
        {
            slist[r].Append(ch);
            r += up ? -1 : 1;
            if (r < 0) 
            {
                r = Math.Min(1, numRows-1);
                up = false;
            }
            else if (r >= numRows)
            {
                r = Math.Max(0, numRows-2);
                up = true;
            }
        }
                var sb = new StringBuilder(s.Length);
        for (int i=0; i<slist.Length; i++)
            sb.Append(slist[i]);
                return sb.ToString();
    }
}
