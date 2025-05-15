// 179. Largest Number   
// https://leetcode.com/problems/largest-number
// Medium 22.2%
// 1065.2618605552475
// Submission: https://leetcode.com/submissions/detail/70510942/
// Runtime: 224 ms
// Your runtime beats 24.53 % of csharp submissions.

public class Solution {
    public string LargestNumber(int[] nums) {
        var array = Array.ConvertAll(nums, x=>x.ToString());
        Array.Sort(array, (a,b)=> (b+a).CompareTo(a+b));
        var result= string.Join("", array);
        return System.Text.RegularExpressions.Regex.Replace(result, "^0+0", "0");
    }
}
