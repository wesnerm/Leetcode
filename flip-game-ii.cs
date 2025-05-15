// 294. Flip Game II    
// https://leetcode.com/problems/flip-game-ii
// Medium 45.9%
// 308.41272812781614
// Submission: https://leetcode.com/submissions/detail/73314811/
// Runtime: 112 ms
// Your runtime beats 100.00 % of csharp submissions.

public class Solution {
        public bool CanWin2(string s) 
    {
        bool winnable = false;
                for (int i=0; (i=s.IndexOf("++", i)) >=0; i++)
            if (!CanWin2(s.Substring(0,i)+"--"+s.Substring(i+2)))
                return true;
        return winnable;
    }
    public bool CanWin3(string s) 
    {
        var sg = new int[s.Length + 1];
        var hash = new BitArray(s.Length + 1);
                for (int i = 2; i <= s.Length; i++)
        {
            hash.SetAll(false);
            for (int j = 0; j < i/2; j++)
                hash[sg[j] ^ sg[i-2-j]] = true;
                        for (int j = 0; j <= i; j++)
                if (hash[j] == false)
                {
                    sg[i] = j;
                    break;
                }
        }
                int ret = 0;
        int cnt = 0;
        for (int i = 0; i < s.Length; i++)
        {
            if (s[i] == '+')
                cnt ++;
            else{
                ret ^= sg[cnt];
                cnt = 0;
            }
        }
        ret ^= sg[cnt];
                return ret != 0;
    }
    public bool CanWin(string s)
    {
        var g= new int[s.Length+1];
        var h= new BitArray(s.Length+1);
                for (int i=2; i<=s.Length; i++)
        {
            h.SetAll(false);
            for (int j=0; j<i/2; j++)
                h[g[j] ^ g[i-2-j]] = true;
                            for (int j=0; j<=i; j++)
                if (h[j] == false)
                {
                    g[i] = j;
                    break;
                }
        }
                int G = 0;
        for (int i=0; i<s.Length; i++)
        {
            int count = 0;
            while (i<s.Length && s[i]=='+')
            {
                i++;
                count++;
            }
            G ^= g[count];
        }
        // Sprague Grundy theorem -- Combinatorial games
        return G != 0;
    }
}
