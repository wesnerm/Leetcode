// 12. Integer to Roman   
// https://leetcode.com/problems/integer-to-roman
// Medium 44.5%
// 1439.1600887224513
// Submission: https://leetcode.com/submissions/detail/70095664/
// Runtime: 96 ms
// Your runtime beats 100.00 % of csharp submissions.

public class Solution {
    public string IntToRoman(int num) {
        var sb = new StringBuilder();        
        Test(ref num, 1000, sb, "M");
        Test(ref num, 900, sb, "CM");
        Test(ref num, 500, sb, "D");
        Test(ref num, 400, sb, "CD");
        Test(ref num, 100, sb, "C");
        Test(ref num, 90, sb, "XC");
        Test(ref num, 50, sb, "L");
        Test(ref num, 40, sb, "XL");
        Test(ref num, 10, sb, "X");
        Test(ref num, 9, sb, "IX");
        Test(ref num, 5, sb, "V");
        Test(ref num, 4, sb, "IV");
        Test(ref num, 1, sb, "I");
        return sb.ToString();
    }
        private void Test(ref int num, int limit, StringBuilder sb, string text)
    {
        while (num>=limit)
        {
            sb.Append(text);
            num -= limit;
        }
    }
}
