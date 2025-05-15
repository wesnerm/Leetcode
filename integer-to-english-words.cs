// 273. Integer to English Words   
// https://leetcode.com/problems/integer-to-english-words
// Hard 21.8%
// 909.7525703052108
// Submission: https://leetcode.com/submissions/detail/70097658/
// Runtime: 60 ms
// Your runtime beats 100.00 % of csharp submissions.

public class Solution {
    public string NumberToWords(int num) {
        if (num < 20) return digits[num];
        var sb = new StringBuilder();
        WriteGroups(num, 1000000000, sb, "Billion");
        WriteGroups(num, 1000000, sb, "Million");
        WriteGroups(num, 1000, sb, "Thousand");
        WriteHundreds(num, sb);
        return sb.ToString();
    }
    public void Add(StringBuilder sb, string text)
    {
        if (text.Length==0) return;
        if (sb.Length>0) sb.Append(' ');
        sb.Append(text);
    }
        public void WriteGroups(int num, int limit, StringBuilder sb, string text)
    {
        if (num<limit) return;
        int n = (num/limit) % 1000;
        if (n == 0) return;
        WriteHundreds(n, sb);
        Add(sb, text);
    }
        public void WriteHundreds(int num, StringBuilder sb)
    {
        num %= 1000;
        int n = num/100;
        if (n>0)
        {
            Add(sb, digits[n]);
            Add(sb, "Hundred");
        }
                num %= 100;
        n = num/10;
        if (n>1)
            Add(sb, tens[n]);
        n = num<20 ? num : num%10;
        if (n != 0)
            Add(sb, digits[n]);
    }
                string[] digits = { "Zero", "One", "Two", "Three", "Four", "Five", "Six", "Seven", "Eight", "Nine", "Ten",
                        "Eleven", "Twelve", "Thirteen", "Fourteen", "Fifteen", "Sixteen", "Seventeen", "Eighteen",
                        "Nineteen" };
    string[] tens = { "", "", "Twenty", "Thirty", "Forty", "Fifty", "Sixty", "Seventy", "Eighty", "Ninety" };
    }
