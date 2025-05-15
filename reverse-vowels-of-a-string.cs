// 345. Reverse Vowels of a String   
// https://leetcode.com/problems/reverse-vowels-of-a-string
// Easy 38.2%
// 885.243280465395
// Submission: https://leetcode.com/submissions/detail/68116177/
// Runtime: 168 ms
// Your runtime beats 22.08 % of csharp submissions.

public class Solution {
    public string ReverseVowels(string s) {
        var sb = new StringBuilder(s);
                int left =0;
        int right = s.Length-1;
                while (left<right)
        {
            if ("aeiou".IndexOf(char.ToLower(s[left]))<0)
                left++;    
            else if ("aeiou".IndexOf(char.ToLower(s[right]))<0)
                right--;
            else
            {
                var tmp = sb[left];
                sb[left++] = sb[right];
                sb[right--] = tmp;
            }
        }
        return sb.ToString();
    }
}
