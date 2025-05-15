// 131. Palindrome Partitioning   
// https://leetcode.com/problems/palindrome-partitioning
// Medium 32.4%
// 663.1852219549984
// Submission: https://leetcode.com/submissions/detail/70685097/
// Runtime: 544 ms
// Your runtime beats 15.52 % of csharp submissions.

public class Solution {
    public IList<IList<string>> Partition(string s) {
        bool[,] p = MakePalindromes(s);
        var list = new List<IList<string>>();
        var buffer = new List<string>();
        Dfs(list, buffer, s, 0, p);        
        return list;
    }
        void Dfs(List<IList<string>> list, List<string> buffer, string s, int index, bool[,] p)
    {
        if (index == s.Length)
        {
            list.Add(new List<string>(buffer));
            return;
        }
                for (int i=index; i<s.Length; i++)
        {
            if (!p[index,i]) continue;
            buffer.Add(s.Substring(index, i-index+1));
            Dfs(list, buffer, s, i+1, p);
            buffer.RemoveAt(buffer.Count-1);
        }
    }
            bool[,] MakePalindromes(string s)
    {
        int n = s.Length;
        var p = new bool[n,n];
        for (int i=0; i<n; i++)
            p[i,i] = true;
                    for (int d=1; d<n; d++)
        for (int i=0,j=d; j<n; i++,j++)
            p[i,j] = s[i]==s[j] && (d==1 || p[i+1,j-1]); 
        return p;            
    }
    }
