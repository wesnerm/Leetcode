// 649. Dota2 Senate   New
// https://leetcode.com/problems/dota2-senate
// Medium 32.9%
// 88.93521139207395
// Submission: https://leetcode.com/submissions/detail/112120113/
// Runtime: 142 ms
// Your runtime beats 94.12 % of csharp submissions.

public class Solution {
    public string PredictPartyVictory(string senate) {
        bool[] skipped = new bool[senate.Length];
        int[] kill = new int[2];
        int[] count = new int[2];
        foreach(var ch in senate)
        {
            if (ch=='D') count[0] ++;
            else count[1] ++;
        }
        for (int i=0; true; i= i+1>=senate.Length ? 0 : i+1)
        {
            if (count[0] == 0) return "Radiant";
            if (count[1] == 0) return "Dire";
                        if (skipped[i]) continue;
                        var ch = senate[i];
            int party = ch=='D' ? 0 : 1;
            if (kill[party] > 0)
            {
                skipped[i] = true;
                kill[party]--;
                continue;
            }
                        kill[1-party]++;
            count[1-party]--;
        }
    }
}
