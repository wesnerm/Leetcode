// 248. Strobogrammatic Number III    
// https://leetcode.com/problems/strobogrammatic-number-iii
// Hard 31.4%
// 401.5399677770881
// Submission: https://leetcode.com/submissions/detail/71438617/
// Runtime: 144 ms
// Your runtime beats 100.00 % of csharp submissions.

public class Solution {
    public int StrobogrammaticInRange(string low, string high) {
        var add1 = IsStrobogrammatic(low) ? 1 : 0;
                    if (low.Length>high.Length
            || low.Length==high.Length && low.CompareTo(high)>0) 
            return 0;
            int hiCount = StrobogrammaticInRange(high);
        int lowCount = StrobogrammaticInRange(low);
        Console.WriteLine("lo#{0} hi#{1} add#{2}", lowCount, hiCount, add1);
        return hiCount - lowCount + add1;
    }
            public int StrobogrammaticInRange(string num, bool zeros = false)
    {
        if (num.Length==0) return 1;
                int ch = num[0] - '0';
        int chLast = num[num.Length-1] - '0';
        if (num.Length==1) 
        {
            if (ch>=8) return 3;
            if (ch>=1) return 2;
            return 1; // 0
        }
                int count = 0;
        // Handle leading digit 
        int strobo0 = StroboDigit(ch);
        if (strobo0 != -1)
        {
            var innerDigits = num.Substring(1,num.Length-2);
            int countInner = StrobogrammaticInRange(innerDigits, true);
            if (IsStrobogrammatic(innerDigits) && chLast<strobo0)
                countInner--;
            count += countInner;
        }
        // Handle fewer numbers 
        int countMinus2 = StrobogrammaticInRange(num.Length-2, true);
        for (int i=1; i<ch; i++)
            if (StroboDigit(i)!=-1) 
                count += countMinus2;
        // Handle leading zero
        if (ch != 0)
            count += zeros 
                ? countMinus2
                : StrobogrammaticInRange(num.Length-1, false);
        Console.WriteLine("StrobogramaticInRange(\"{0}\", {1})={2}", num, zeros, count);
        return count; // 0
    }
    public int StrobogrammaticInRange(int digits, bool zeros=false)
    {
        if (digits==0) return 1; // 
        if (digits==1) return 3; // 0 1 8
        // 11 88 69 96  -- 00 if zeros
                int result = zeros
            ? 5 * StrobogrammaticInRange(digits-2, true)
            : 4 * StrobogrammaticInRange(digits-2, true)
                 + StrobogrammaticInRange(digits-1, false);
                         Console.WriteLine("StrobogramaticInRange({0}, {1})={2}", digits, zeros, result);
        return result;
    }
        int StroboDigit(int digit)
    {
        switch(digit)
        {
            case 0: case 1: case 8: return digit;
            case 6: return 9;
            case 9: return 6;
        }
        return -1;
    }
        public bool IsStrobogrammatic(string num)
    {
        int left=0;
        int right = num.Length-1;
        while (left<=right)
            if (StroboDigit(num[left++]-'0') != num[right--]-'0') 
                return false;
        return true;
    }
}
