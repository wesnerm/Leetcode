// 66. Plus One   
// https://leetcode.com/problems/plus-one
// Easy 38.1%
// 1331.974223325595
// Submission: https://leetcode.com/submissions/detail/67531301/
// Runtime: 566 ms
// Your runtime beats 1.67 % of csharp submissions.

public class Solution {
    public int[] PlusOne(int[] digits) {
        int numberOfNines = 0;
        for (int i=digits.Length-1; i>=0 && digits[i]==9; i--)
            numberOfNines++;
                    int[] result;
        if (numberOfNines >= digits.Length)
        {
            result=new int[numberOfNines+1];
            result[0]=1;
            return result;
        }
                    result = (int[]) digits.Clone();
        for (int i=0; i<numberOfNines; i++)
            result[digits.Length-1-i] = 0;
        result[digits.Length-1-numberOfNines]++;
        return result;
    }
}
