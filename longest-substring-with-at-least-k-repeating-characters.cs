// 395. Longest Substring with At Least K Repeating Characters   
// https://leetcode.com/problems/longest-substring-with-at-least-k-repeating-characters
// Medium 35.5%
// 723.8479675465277
// Submission: https://leetcode.com/submissions/detail/73104732/
// Runtime: 109 ms
// Your runtime beats 84.62 % of csharp submissions.

public class Solution {
    public int LongestSubstring2(string s, int k) {
        var segTree = new SegTree(26);
        int maxlen = 0;
        for (int i=0; i<s.Length; i++)
        {
            if (i>0 && s[i-1]==s[i]) continue;
                        segTree.Clear();
            for (int j=i; j<s.Length;j++)
            {
                segTree[s[j]-'a']++;
                                if (segTree.Sum(0,26) != segTree.SumAll())
                {
                    Console.WriteLine("{0} != {1} at {2},{3}", segTree.Sum(0,25), segTree.SumAll(), i, j);
                    throw new Exception();
                }
                                if (segTree.SumAll() >= k)
                    maxlen = Math.Max(maxlen, j-i+1);
            }
        }
                return maxlen;
    }
    public int LongestSubstring(string s, int k) 
    {
        var prevchar = new int[26];
        var letterCount = new int[26];
        var prevLetter = new int[s.Length];
        var countLetter = new int[s.Length];
        for (int i=0; i<s.Length; i++)
        {
            var ch = s[i]-'a';
            var count = ++letterCount[ch];
            countLetter[i] = count;
            prevLetter[i] = count>1 ? prevchar[ch] : -1;
            prevchar[ch] = i;
            // Console.WriteLine("i={0}, countLetter={1}, prevLetter={2}", i, countLetter[i], prevLetter[i]);
        }
                int maxlen = 0;
                for (int i=0; i<s.Length; i++)
        {
            int seen = 0;
            int jMax = i;
            int distinct = 0;
            for (int j=i; j>=0 && jMax>=0; j--)
            {
                int ch = s[j]-'a';
                if ((seen & 1<<ch) == 0)   
                {
                    if (countLetter[j] < k) break;
                                        seen |= 1<< ch;
                    distinct++;
                    jMax = Math.Min(jMax, i-distinct*k+1);
                                        int x = j;
                    for (int ii=1; ii < k; ii++)
                        x = prevLetter[x];
                    jMax = Math.Min(jMax, x);
                                        while (i+1 < s.Length && (seen & 1<<(s[i+1]-'a')) == 1)
                        i++;
                }
                if (j<=jMax)
                    maxlen = Math.Max(maxlen, i-j+1);
            }
        }
            return maxlen;
    }
    public class SegTree
    {
        int [] tree;
                public SegTree(int size)
        {
            tree=new int[2*size];
        }
                public void Clear()
        {
            Array.Clear(tree, 0, tree.Length);
        }
                public int SumAll()
        {
            return tree[1];
        }
                public int this[int index]
        {
            get { return tree[index + tree.Length/2]; }
            set {
                int i = index+tree.Length/2;
                tree[i] = value;
                for (; i>1; i>>=1)
                    tree[i>>1] = Combine(tree[i], tree[i^1]); 
            }
        }
        public int Sum(int left, int right1)
        {
            left+=tree.Length/2;
            right1+=tree.Length/2;
            int result = 0;
            while (left<right1)
            {
                if ((left&1)==1) result=Combine(result, tree[left++]);
                if ((right1&1)==1) result=Combine(result, tree[--right1]);
                left>>=1;
                right1>>=1;
            }
            return result;
        }
                public int Combine(int x, int y)
        {
            if (x==0) return y;
            if (y==0) return x;
            return Math.Min(x,y);
        }
            }
}
