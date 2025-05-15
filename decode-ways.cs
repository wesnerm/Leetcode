// 91. Decode Ways   
// https://leetcode.com/problems/decode-ways
// Medium 19.4%
// 732.5036792609947
// Submission: https://leetcode.com/submissions/detail/70630811/
// Runtime: 144 ms
// Your runtime beats 6.92 % of csharp submissions.

public class Solution {
    public int NumDecodings(string s) {
        if (s=="") return 0;
        int prev = 1;
        int count = 1;
                for (int i=s.Length-1; i>=0; i--)
        {
            int newCount = 0;
            // Misplaced zero            
            if (s[i] == '0')
            {
            }
            else
            {
                // One characters            
                if (i+1==s.Length || s[i+1] != '0')
                {
                    newCount += count;
                }
                                // Two characters
                if (i+1<s.Length  
                        && (s[i]=='1' || s[i]=='2' && s[i+1]<'7')
                        && (i+2>=s.Length || s[i+2] != '0'))
                {
                    newCount += prev;
                }
            }
            prev = count;
            count = newCount;
                        //Console.WriteLine("prev={0} count={1}", prev, count);
        }
        return count;
    }
        public int Fib(int n)
    {
            var sqrt5 = Math.Sqrt(5);
            var result = (int)(Math.Pow((1 + sqrt5) / 2, n+1)/sqrt5 + 0.5);
            Console.WriteLine("fib({0}) = {1}", n, result);
            return result;
    }
}
