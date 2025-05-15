// 293. Flip Game   
// https://leetcode.com/problems/flip-game
// Easy 55.2%
// 368.484185204588
// Submission: https://leetcode.com/submissions/detail/68207285/
// Runtime: 581 ms
// 

public class Solution {
    public IList<string> GeneratePossibleNextMoves(string s) {
        var list = new List<string>();
        for (int i=0; (i=s.IndexOf("++", i)) >=0; i++)
            list.Add(s.Substring(0,i)+"--"+s.Substring(i+2));
        return list;
    }
}
