// 266. Palindrome Permutation   
// https://leetcode.com/problems/palindrome-permutation
// Easy 56.5%
// 502.17871322906706
// Submission: https://leetcode.com/submissions/detail/67725426/
// Runtime: 140 ms
// Your runtime beats 8.33 % of csharp submissions.

public class Solution {
    public bool CanPermutePalindrome(string s) {
        var array=s.ToCharArray();
        Array.Sort(array);
        int countOdd = 0;
        for (int i=0; i<array.Length; i++)
        {
            int count = 1;
            char ch = array[i];
            while (i+1<array.Length && array[i+1]==ch)
            {
                count++;
                i++;
            }
            if (count %2 == 1) countOdd++;
        }
                return countOdd <2;
    }
}
