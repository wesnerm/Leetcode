// 158. Read N Characters Given Read4 II - Call multiple times   
// https://leetcode.com/problems/read-n-characters-given-read4-ii-call-multiple-times
// Hard 24.2%
// 493.91814835423844
// Submission: https://leetcode.com/submissions/detail/68508367/
// Runtime: 508 ms
// Your runtime beats 9.09 % of csharp submissions.

/* The Read4 API is defined in the parent class Reader4.
      int Read4(char[] buf); */
public class Solution : Reader4 {
    /**
     * @param buf Destination buffer
     * @param n   Maximum number of characters to read
     * @return    The number of characters read
     */
    public int Read(char[] buf, int n) {
                int offset=0;
        do
        {
            int copy = Math.Min(bufferCount, n-offset);
            if (copy > 0)
            {
                Array.Copy(buffer, 0, buf, offset, copy);
                offset += copy;            
                bufferCount -= copy;
                if (bufferCount>0)
                    Array.Copy(buffer, copy, buffer, 0, bufferCount);
            }
                        if (offset == n || eof)
                break;
                        bufferCount = Read4(buffer);
            if (bufferCount < 4)
                eof = true;
        }
        while (true);
        return offset;
    }
        private int bufferCount = 0;
    private bool eof;
    private char[] buffer = new char[4];
    }
