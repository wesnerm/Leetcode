// 422. Valid Word Square   
// https://leetcode.com/problems/valid-word-square
// Easy 36.1%
// 163.60396205567034
// Submission: https://leetcode.com/submissions/detail/101881672/
// Runtime: 145 ms
// Your runtime beats 72.73 % of csharp submissions.

public class Solution {
    public bool ValidWordSquare(IList<string> words) {
                Console.WriteLine("Fail");
                if (words == null)
            return false;
        for (int i = 0; i < words.Count; i++)
        {
            var w = words[i];
            for (int j = 0; j < w.Length; j++)
            {
                if (j >= words.Count 
                    || words[j]==null
                    || i >= words[j].Length
                    || w[j] != words[j][i])
                    return false;
            }
        }
        return true;
    }
}
