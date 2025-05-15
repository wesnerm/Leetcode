// 393. UTF-8 Validation   
// https://leetcode.com/problems/utf-8-validation
// Medium 34.8%
// 399.75404730497746
// Submission: https://leetcode.com/submissions/detail/73049592/
// Runtime: 159 ms
// Your runtime beats 76.92 % of csharp submissions.

public class Solution {
    public bool ValidUtf8(int[] data) {
        int expect = 0;
        foreach (var dat in data)
        {
            var d = dat;
            if (expect != 0)
            {
                if ((d&0xc0) != 0x80)
                    return false;
                expect--;
                continue;
            }
                        if ((d&0x80)==0) 
                continue;
                            if ((d&0xc0)==0x80)
                return false;
            while ((d&0xc0) == 0xc0)
            {
                expect++;
                d<<=1;                
            }
                        if (expect > 4) 
                return false;
        }
                return expect==0;
    }
}
