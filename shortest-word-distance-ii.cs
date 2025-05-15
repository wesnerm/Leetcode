// 244. Shortest Word Distance II   
// https://leetcode.com/problems/shortest-word-distance-ii
// Medium 36.7%
// 523.8516464999559
// Submission: https://leetcode.com/submissions/detail/70094372/
// Runtime: 484 ms
// 

public class WordDistance {
        Dictionary<string, List<int>> list = new Dictionary<string,List<int>>();
        public WordDistance(string[] words) {
        int i = 0;
        foreach(var w in words)
        {
            if (!list.ContainsKey(w)) list[w] = new List<int>();
            list[w].Add(i++);
        }
    }
    public int Shortest(string word1, string word2) {
        var list1 = list[word1];
        var list2 = list[word2];
        int i1=0;
        int i2=0;
        int min = int.MaxValue;
        while (i1<list1.Count && i2<list2.Count)
        {
            min = Math.Min(min, Math.Abs(list1[i1]-list2[i2]));
            if (list1[i1] < list2[i2])
                i1++;
            else
                i2++;
        }
                return min;
    }
}
// Your WordDistance object will be instantiated and called as such:
// WordDistance wordDistance = new WordDistance(words);
// wordDistance.Shortest("word1", "word2");
// wordDistance.Shortest("anotherWord1", "anotherWord2");
