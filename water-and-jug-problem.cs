// 365. Water and Jug Problem   
// https://leetcode.com/problems/water-and-jug-problem
// Medium 26.9%
// 364.5976516180955
// Submission: https://leetcode.com/submissions/detail/71192526/
// Runtime: 52 ms
// Your runtime beats 34.78 % of csharp submissions.

public class Solution {
    public bool CanMeasureWater(int x, int y, int z) {
        // ax + by = c
        // ax + by = gcd(a,b)
                if (z>x+y)
            return false;
                if (z==0) return true;
        var g = Gcd(x,y);
        if (g==0) return false;
                return z % g == 0;        
    }
        int Gcd(int a, int b)
    {
        if (a>b) return Gcd(b,a);
        if (a==0) return b;
        return Gcd(b%a, a);
    }
}
