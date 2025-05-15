// 394. Decode String   
// https://leetcode.com/problems/decode-string
// Medium 40.9%
// 585.2498896773419
// Submission: https://leetcode.com/submissions/detail/73104024/
// Runtime: 108 ms
// Your runtime beats 100.00 % of csharp submissions.

public class Solution {
    public string DecodeString(string s) {
        var sb = new StringBuilder();
                for (int i=0; i<s.Length; i++)
        {
            if (s[i]>='0' || s[i]<='9')
            {
                int braces = 0;
                int start = -1;
                int j=i;
                for (; j<s.Length; j++)
                {
                    if (s[j] == ']' && --braces==0)
                        break;
                                        if (s[j]=='[') 
                    {
                        if (start==-1) start = j;
                        braces++;
                    }
                }
                                int count;
                if (start>=i && j<s.Length && int.TryParse(s.Substring(i, start-i), out count))
                {
                    var insert = DecodeString(s.Substring(start+1, j-start-1));
                    while(count-- > 0)
                        sb.Append(insert);
                    i=j;
                    continue;
                }
            }
                        sb.Append(s[i]);
        }
        return sb.ToString();
    }
}
