// 500. Keyboard Row   
// https://leetcode.com/problems/keyboard-row
// Easy 60.2%
// 615.3114317058803
// Submission: https://leetcode.com/submissions/detail/101894652/
// Runtime: 435 ms
// Your runtime beats 67.59 % of csharp submissions.

using System.Linq;
public class Solution {
    public string[] FindWords(string[] words) {
        var row1 = "qwertyuiop";
        var row2 = "asdfghjkl";
        var row3 = "zxcvbnm";
                int[] mask = new int[32];
                foreach(var c in row1) mask[c&31] = 1;
        foreach(var c in row2) mask[c&31] = 2;
        foreach(var c in row3) mask[c&31] = 3;
             var list = words.ToList();
        list.RemoveAll(w=>
        {
            int mode = 0;
            foreach(var c in w)
            {
                var m = mask[c&31];
                if (mode == 0) mode = m;
                if (m != mode) return true;
            }
            return false;
        });
                return list.ToArray();
    }
}
