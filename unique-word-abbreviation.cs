// 288. Unique Word Abbreviation   
// https://leetcode.com/problems/unique-word-abbreviation
// Medium 16.2%
// 368.49801794070584
// Submission: https://leetcode.com/submissions/detail/67536626/
// Runtime: 588 ms
// 

public class ValidWordAbbr {
    HashSet<string> dict = new HashSet<string>();
    Dictionary<string, int> abbrevs = new Dictionary<string, int>();
        public ValidWordAbbr(string[] dictionary) {
        dict.UnionWith(dictionary);
                foreach(var w in dict)
        {
            var abbrev = Abbreviation(w);
            if (!abbrevs.ContainsKey(abbrev))
                abbrevs[abbrev] = 1;
            else
                abbrevs[abbrev]++;
        }
    }
    public bool IsUnique(string word) {
        int count;
        abbrevs.TryGetValue(Abbreviation(word), out count);
        return count == (dict.Contains(word) ? 1 : 0);
    }
        public string Abbreviation(string word)
    {
        if (word.Length<=2)
            return word;
        return word[0] + (word.Length-2).ToString() + word[word.Length-1];
    }
}
// Your ValidWordAbbr object will be instantiated and called as such:
// ValidWordAbbr vwa = new ValidWordAbbr(dictionary);
// vwa.IsUnique("word");
// vwa.IsUnique("anotherWord");
