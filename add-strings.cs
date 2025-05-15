// 415. Add Strings   
// https://leetcode.com/problems/add-strings
// Easy 41.2%
// 480.5759146757875
// Submission: https://leetcode.com/submissions/detail/101881561/
// Runtime: 179 ms
// Your runtime beats 28.81 % of csharp submissions.

public class Solution {
    public string AddStrings(string num1, string num2) {
        int len = Math.Max(num1.Length, num2.Length) + 1;
        var list = new List<char>(len);
        int carry = 0;
        for (int i=0; i<len; i++)
        {
            int d1 = i<num1.Length ? num1[num1.Length-1-i] - '0' : 0;
            int d2 = i<num2.Length ? num2[num2.Length-1-i] - '0' : 0;
            int d = d1+d2+carry;
            list.Add((char)('0' + (d%10)));
            carry = d/10;
        }
        int j;        
        for (j=len-1; j>0; j--)
            if (list[j] != '0')
                break;
        list.RemoveRange(j+1, list.Count-(j+1));
        list.Reverse();
        return new String(list.ToArray());
    }
}
