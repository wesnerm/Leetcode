// 71. Simplify Path   
// https://leetcode.com/problems/simplify-path
// Medium 24.9%
// 679.1964924442523
// Submission: https://leetcode.com/submissions/detail/70737685/
// Runtime: 134 ms
// Your runtime beats 66.67 % of csharp submissions.

public class Solution {
    public string SimplifyPath(string path) {
        var sb = new StringBuilder(path);
        sb.Append('/');
        int write = 0;
        int lastDir = -1;
                for (int read=0; read<sb.Length; read++)
        {
            var ch = sb[read];
            if (ch!='/')
            {
                sb[write++] = ch;
                continue;
            }
                        // Merge slash characters except at root
            if (lastDir == write-1 && lastDir>=0)
                continue;
                        // Handle . and ..
            if (lastDir>=0 && lastDir+1<write && sb[lastDir+1]=='.')
            {
                if (write-lastDir==2)
                {
                    write = lastDir+1;
                    continue;
                }
                if (write-lastDir==3 && sb[lastDir+1]=='.')
                {
                    if (lastDir == -1)
                        continue;
                                        write = lastDir<=0 ? lastDir : lastDir-1;
                    while (write>=0 && sb[write] != '/')
                        write--;
                    if (write<0)
                    {
                        lastDir = -1;
                        write = 0;
                        continue;
                    }
                }
            }
                        lastDir = write;
            sb[write++] ='/';
        }
                        // Remove trailing backslash
        if (write>1 && sb[write-1]=='/')
            write--;
                sb.Length=write;
                return sb.ToString();
    }
    }
