// 402. Remove K Digits   
// https://leetcode.com/problems/remove-k-digits
// Medium 26.1%
// 261.7572803050967
// Submission: https://leetcode.com/submissions/detail/74815975/
// Runtime: 85 ms
// Your runtime beats 100.00 % of csharp submissions.

public class Solution {
        public string RemoveKdigits(string num, int k)
        {
            int size = num.Length - k;
            if (size <= 0) return "0";
            char[] array = new char[size];
            int j = 0;
            for (int i = 0; i < num.Length; i++)
            {
                while (j > 0 && num[i] < array[j - 1] && num.Length - i + j > size)
                    j--;
                if (j < size)
                    array[j++] = num[i];
            }
            var result = new string(array);
            while (result.Length > 1 && result[0] == '0')
                result = result.Substring(1);
            if (result=="")
                result="0";
            return result;
        }
}
