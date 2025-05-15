// 17. Letter Combinations of a Phone Number   
// https://leetcode.com/problems/letter-combinations-of-a-phone-number
// Medium 34.3%
// 1137.8128943742686
// Submission: https://leetcode.com/submissions/detail/68240561/
// Runtime: 477 ms
// Your runtime beats 78.48 % of csharp submissions.

public class Solution {
        string[] mapper = 
    {
        "0",
        "1",
        "abc",
        "def",
        "ghi",
        "jkl",
        "mno",
        "pqrs",
        "tuv",
        "wxyz",
    };
        List<string> result;
    StringBuilder sb;
            public IList<string> LetterCombinations(string digits) {
        result = new List<string>();
        sb = new StringBuilder(digits);
        Process(0, digits);
        return result;
    }
        public void Process(int index, string digits)
    {
        if (index==digits.Length)
        {
            if (index != 0)
                result.Add(sb.ToString());
            return;
        }
                int digit = digits[index]-'0';
        foreach(var d in mapper[digit])
        {
            sb[index] = d;
            Process(index+1, digits);
        }
    }
            }
