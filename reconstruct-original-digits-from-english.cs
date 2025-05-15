// 423. Reconstruct Original Digits from English   
// https://leetcode.com/problems/reconstruct-original-digits-from-english
// Medium 43.3%
// 328.87703460279437
// Submission: https://leetcode.com/submissions/detail/101881733/
// Runtime: 192 ms
// Your runtime beats 21.43 % of csharp submissions.

public class Solution {
    private string[] nums = new string[]
    {
        "zero", //z
        "one",
        "two",
        "three",
        "four",
        "five", // v
        "six", // x
        "seven",
        "eight", //g
        "nine",
    };
    // 2 3 4 5 6 7 8 9 1 0
    public string OriginalDigits(string s)
    {
        string result = "";
        var counts = new int[26];
        foreach (var c in s)
            counts[c - 'a']++;
        var sb = new StringBuilder();
        int[] ns = new int[10];
        foreach(var v in new int[] { 0,2,4,5,6,7,8,9,5,3,1})
            Append(counts, v, ns);
        for (int v=0; v<10; v++)
            for (int i = 0; i < ns[v]; i++)
                sb.Append(v);
        return sb.ToString();
    }
    void Append(int[] counts, int j, int[] ns)
    {
        while (Add(counts, j, -1))
            ns[j]++;
    }
    bool Add(int[] lcount, int d, int count)
    {
        foreach (var c in nums[d])
            if (lcount[c - 'a'] + count < 0)
                return false;
        foreach (var c in nums[d])
            lcount[c - 'a'] += count;
        return true;
    }        
}
