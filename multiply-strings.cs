// 43. Multiply Strings   
// https://leetcode.com/problems/multiply-strings
// Medium 26.7%
// 857.9350575082148
// Submission: https://leetcode.com/submissions/detail/70575152/
// Runtime: 320 ms
// Your runtime beats 7.35 % of csharp submissions.

public class Solution {
    public string Multiply(string num1, string num2) {
        if (num1.Length > num2.Length)
            return Multiply(num2, num1);
                if (num1.Length==0 || num1=="0")
            return "0";
                if (num1.Length==1)
        {
            int d = num1[0] - '0';
            if (d < 2)
                return d==0 ? "0" : num2;
            var sb = new StringBuilder();
            int carry = 0;
            for (int i=num2.Length-1; i>=0; i--)
            {
                int sum = carry + d * (num2[i] - '0');
                carry = sum / 10;
                sb.Append(sum % 10);
            }
                        if (carry > 0)
                sb.Append(carry);
                            Reverse(sb);
            //Console.WriteLine("{0}*{1}={2}", num1, num2, sb);
            return sb.ToString();
        }
                int mid = num2.Length/2;
        var left = Multiply(num1, num2.Substring(0,mid));
        var right = Multiply(num1, num2.Substring(mid));
        var result = Add(Shift(left,num2.Length-mid), right);
        //Console.WriteLine("{0}*{1}={2}", left, right, result);
        return result;
    }
        public string Shift(string num, int n)
    {
        if (num=="0" || num=="")
            return num;
        return num + new string('0', n);
    }
            public string Add(string num1, string num2)
    {
        if (num1.Length > num2.Length)
            return Add(num2, num1);
                    var sb = new StringBuilder();
        int carry = 0;
                for (int i=0; i<num2.Length; i++)
        {
            int d1 = num2[num2.Length-i-1]-'0';
            int d2 = i<num1.Length ? num1[num1.Length-i-1]-'0' : 0;
            int sum = carry + d1 + d2;
            carry = sum/10;
            sb.Append(sum % 10);
        }
                if (carry > 0)
            sb.Append(carry);
        Reverse(sb);
        //Console.WriteLine("{0}+{1}={2}", num1, num2, sb);
        return sb.ToString();
    }
        public void Reverse(StringBuilder sb)
    {
        int left = 0;
        int right = sb.Length-1;
        while (right > 0 && sb[right]=='0') right--;
        sb.Length = right+1;
        while (left < right)
        {
            char tmp = sb[left];
            sb[left++] = sb[right];
            sb[right--] = tmp;
        }
    }
    }
