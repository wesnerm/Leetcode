// 246. Strobogrammatic Number   
// https://leetcode.com/problems/strobogrammatic-number
// Easy 39.5%
// 372.73131519214246
// Submission: https://leetcode.com/submissions/detail/68117062/
// Runtime: 136 ms
// Your runtime beats 3.23 % of csharp submissions.

public class Solution {
    public bool IsStrobogrammatic(string num) {
        int left=0;
        int right = num.Length-1;
                while (left<=right)
        {
            var vv1 = num[left];
            var vv2 = num[right];
            var v1 = vv1<vv2 ? vv1:vv2;
            var v2 = vv1<vv2 ? vv2:vv1;
                    switch(v1)
            {
                case '0':
                case '1':
                case '8':
                    if (v2 != v1) return false;
                    break;
                case '6':
                    if (v2 != '9') return false;
                    break;
                default:
                    return false;
            }
            left++;
            right--;
        }
                return true;
    }
}
