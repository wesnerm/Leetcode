// 524. Longest Word in Dictionary through Deleting   
// https://leetcode.com/problems/longest-word-in-dictionary-through-deleting
// Medium 42.4%
// 265.6114993222557
// Submission: https://leetcode.com/submissions/detail/111578610/
// Runtime: 238 ms
// Your runtime beats 62.50 % of csharp submissions.

public class Solution {
    public string FindLongestWord(string s, IList<string> d) {
        var list = new List<string>(d);
        list.Sort((a,b)=> {
            int cmp = -a.Length.CompareTo(b.Length);
            if (cmp != 0) return cmp;
            return a.CompareTo(b);
        });
                foreach (var w in list)
        {
            if (Acceptable(s, w))
                return w;
        }
                return "";
    }
        public bool Acceptable(string large, string small)
    {
        int left = 0;
        foreach(var ch in small)
        {
            while (true)
            {
                if ( left >= large.Length ) return false;
                if ( large[left++]==ch ) break;
            }
        }
        return true;
    }
}
