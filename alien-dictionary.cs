// 269. Alien Dictionary    
// https://leetcode.com/problems/alien-dictionary
// Hard 23.2%
// 638.0417327467339
// Submission: https://leetcode.com/submissions/detail/68312484/
// Runtime: 168 ms
// Your runtime beats 7.14 % of csharp submissions.

public class Solution {
    Dictionary<char, HashSet<char>> dict ;
    Dictionary<char, int> depthMap;
    HashSet<char>visited ;
    HashSet<char> alphabet;
    bool cycle;
    public string AlienOrder(string[] words) 
    {
        dict = new Dictionary<char, HashSet<char>>();
        depthMap = new Dictionary<char, int>();
        visited = new HashSet<char>();
        alphabet = new HashSet<char>();
                        for (int i=0; i<words.Length; i++)
            alphabet.UnionWith(words[i]);
        for (int i=1; i<words.Length; i++)
        {
            var w1 = words[i-1].ToLower();
            var w2 = words[i].ToLower();
                        int j=0;
            for (j=0; j<w1.Length && j<w2.Length && w1[j]==w2[j]; j++)
            {
            }
                        if (j<w1.Length && j<w2.Length)            
            {
                var c1 = w1[j];
                var c2 = w2[j];
                            if (!dict.ContainsKey(c1))
                    dict[c1] = new HashSet<char>();
                dict[c1].Add(c2);
            }
        }
                        foreach(var ch in dict.Keys)
            TopSort(dict, ch);
                if (cycle)
            return "";
                var list = alphabet.OrderByDescending(x=>depthMap.ContainsKey(x) ? depthMap[x] : 0).ToArray();
        return new string(list);
    }
        public int TopSort(Dictionary<char, HashSet<char>> dict, char ch)
    {
        int depth;
        if (depthMap.TryGetValue(ch, out depth))
            return depth;
        if (visited.Contains(ch))
        {
            depth = short.MaxValue;
            cycle = true;
        }
        else
        {
            visited.Add(ch);
            depth = 1;
            if (dict.ContainsKey(ch))
                foreach(var letter in dict[ch])
                {
                    var childDepth = TopSort(dict, letter);
                    depth = Math.Max(depth, 1+childDepth);
                }
            visited.Remove(ch);
        }
        depthMap[ch] = depth;
        return depth;
    }
        public static string Reverse( string s )
    {
        char[] charArray = s.ToCharArray();
        Array.Reverse( charArray );
        return new string( charArray );
    }
}
