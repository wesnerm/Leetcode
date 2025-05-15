// 425. Word Squares   
// https://leetcode.com/problems/word-squares
// Hard 41.9%
// 358.5613803920932
// Submission: https://leetcode.com/submissions/detail/101839529/
// Runtime: 1338 ms
// Your runtime beats 0.00 % of csharp submissions.

public class Solution {
   List<IList<string>> results;
    string[] words;
    public IList<IList<string>> WordSquares(string[] words)
    {
        this.results = new List<IList<string>>();
        this.words = words;
        Array.Sort(words);
        if (words.Length == 0 || words[0] == "") return results;
        int depth = words[0].Length;
        Dfs(new List<string>(), depth);
        return results;
    }
    public void Dfs(List<string> list, int maxdepth)
    {
        if (list.Count == maxdepth)
        {
            results.Add(new List<string>(list));
            return;
        }
        var target = new StringBuilder();
        for (int i = 0; i < list.Count; i++)
            target.Append(list[i][list.Count]);
        var t = target.ToString();
        int j = BinSearch(words, t);
        for (; j < words.Length && words[j].StartsWith(t); j++)
        {
            list.Add(words[j]);
            Dfs(list, maxdepth);
            list.RemoveAt(list.Count - 1);
        }
    }
    int BinSearch(string[] list, string word)
    {
        int left = 0;
        int right = list.Length - 1;
        while (left <= right)
        {
            int mid = (left + right) / 2;
            if (String.CompareOrdinal(list[mid], word) < 0)
                left = mid + 1;
            else
                right = mid - 1;
        }
        return left;
    }
}
