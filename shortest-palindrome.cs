// 214. Shortest Palindrome   
// https://leetcode.com/problems/shortest-palindrome
// Hard 23.8%
// 772.2533411937316
// Submission: https://leetcode.com/submissions/detail/73252771/
// Runtime: 119 ms
// Your runtime beats 100.00 % of csharp submissions.

public class Solution {
    public string ShortestPalindrome(string s) {
        int n = s.Length;
        if (n<=1) return s;
                var pat = s + "&" + Reverse(s);
        var t = new int[pat.Length];
        /*
        for (int i=1; i<pat.Length; i++)
        {
            t[i] = t[i-1];
            while (t[i]>0 && pat[i] != pat[t[i]])
                t[i] = t[t[i]-1];
            t[i] += pat[i] == pat[t[i]] ? 1 : 0;
        }*/
        int index=0;
        for (int i=1; i<pat.Length; i++)
        {
            while (index>0 && pat[i] != pat[index])
                index = t[index-1];
            t[i] = index += pat[i] == pat[index] ? 1 : 0;
        }
        /*
        int index = 0;
        for(int i = 1; i < s.Length; ){
            if(s.charAt(index) == s.charAt(i)){
                table[i] = ++index;
                i++;
            } else if(index > 0){
                index = table[index-1];
            } else {
                index = 0;
                i++;
            }
        }*/
                return Reverse(s.Substring(t[2*n])) + s;
        //return pat.Substring(n+1, n-t[2*n]) + s;
    }
    public string ShortestPalindrome2(string s)
    {
        int i;
        for (i=s.Length; i>1; i--)
        {
            int left = 0;
            int right = i-1;
            while (left<right)
            {
                if (s[left] != s[right])
                    break;
                left++;
                right--;
            }
            if (left>=right)
                break;
        }
        return Reverse(s.Substring(i)) + s;
    }
    /*
    public string ShortestPalindrome(string s)
    {
        int j = 0;
        for (int i = s.Length- 1; i >= 0; i--) 
            if (s[i] == s[j]) 
            j++;
        if (j == s.Length) 
            return s;
        var suffix = s.Substring(j);
        return Reverse(suffix) + ShortestPalindrome(s.Substring(0, j)) + suffix;
    }
*/
    public string Reverse(string s)
    {
        var sb = new StringBuilder(s);
        int left =0;
        int right = s.Length-1;
        while (left<right)
        {
            char tmp = sb[left];
            sb[left++] = sb[right];
            sb[right--] = tmp;
        }
                return sb.ToString();
    }
            }
