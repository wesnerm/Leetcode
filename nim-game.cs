// 292. Nim Game   
// https://leetcode.com/problems/nim-game
// Easy 55.1%
// 2673.687498180169
// Submission: https://leetcode.com/submissions/detail/68212483/
// Runtime: 52 ms
// Your runtime beats 18.68 % of csharp submissions.

public class Solution {
        public static Dictionary<int, bool>dict = new Dictionary<int, bool>();
        public bool CanWinNim(int n) {
        return n % 4 != 0;
        //        bool result;
//        if (dict.TryGetValue(n, out result))
//            return result;
//        dict[n] = result = !CanWinNim(n-1) || !CanWinNim(n-2) || !CanWinNim(n-3);
//        return result;
            }
        }
