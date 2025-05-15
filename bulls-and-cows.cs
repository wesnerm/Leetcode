// 299. Bulls and Cows   
// https://leetcode.com/problems/bulls-and-cows
// Medium 34.2%
// 765.2732350681581
// Submission: https://leetcode.com/submissions/detail/70447100/
// Runtime: 160 ms
// Your runtime beats 15.15 % of csharp submissions.

public class Solution {
    public string GetHint(string secret, string guess) {
                int bulls = 0;
        int cows = 0;
        int bits = 0;
        var dict = new Dictionary<int, int>();
        for (int i=0; i<secret.Length; i++)
            dict[secret[i]] = 0;
        for (int i=0; i<secret.Length; i++)
            dict[secret[i]]++;
                for (int i=0; i<secret.Length; i++)
        {
            if (guess[i] == secret[i])
            {
                bulls++;
                dict[guess[i]]--;
            }
        }
        for (int i=0; i<secret.Length; i++)
        {
            if (guess[i] != secret[i] && dict.ContainsKey(guess[i]) && dict[guess[i]]-- > 0)
                cows++;
        }
                return bulls + "A" + cows + "B";
            }
}
