// 388. Longest Absolute File Path   
// https://leetcode.com/problems/longest-absolute-file-path
// Medium 36.0%
// 1466.051871767213
// Submission: https://leetcode.com/submissions/detail/105463395/
// Runtime: 109 ms
// Your runtime beats 78.72 % of csharp submissions.

public class Solution {
    public int LengthLongestPath(string input) {
        var stack = new Stack<int>();
        var split = input.Split('\n');
        int maxlen = 0;
        foreach(var w in split)
        {
            var indent = 0;
            while (indent<w.Length && w[indent]=='\t')
                indent++;
            while (indent<stack.Count)
                stack.Pop();
            int pathLen = stack.Count>0 ? stack.Peek() : 0;
            int fileLen = w.Length-indent;
                        bool isFile = w.IndexOf('.', indent) >=0;
            if (isFile)
                maxlen = Math.Max(maxlen, pathLen + fileLen);                                 
            else
                stack.Push(pathLen + fileLen + 1);
        }
                return maxlen;
    }
}
