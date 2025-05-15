// 157. Read N Characters Given Read4   
// https://leetcode.com/problems/read-n-characters-given-read4
// Easy 29.0%
// 522.763387516505
// Submission: https://leetcode.com/submissions/detail/70450539/
// Runtime: 144 ms
// Your runtime beats 5.13 % of csharp submissions.

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
