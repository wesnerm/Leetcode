// 89. Gray Code   
// https://leetcode.com/problems/gray-code
// Medium 40.5%
// 904.601726075946
// Submission: https://leetcode.com/submissions/detail/70779072/
// Runtime: 402 ms
// Your runtime beats 14.29 % of csharp submissions.

public class Solution {
    public IList<int> GrayCode(int n) {
        var list = new List<int>();
        int n_2 = 1<<n;
        for (int i =0; i<n_2; i++)
            list.Add( i ^ (i>>1));
        return list;
    }
        // Graycode(i) = i ^ (i/2);
             /*
     * This function converts a reflected binary
     * Gray code number to a binary number.
     * Each Gray code bit is exclusive-ored with all
     * more significant bits.
     */
    uint grayToBinary(uint num)
    {
        uint mask;
        for (mask = num >> 1; mask != 0; mask = mask >> 1)
            num = num ^ mask;
        return num;
    }
        /*
     * A more efficient version, for Gray codes of 32 or fewer bits.
     */
    uint grayToBinary32(uint num)
    {
        num = num ^ (num >> 16);
        num = num ^ (num >> 8);
        num = num ^ (num >> 4);
        num = num ^ (num >> 2);
        num = num ^ (num >> 1);
        return num;
    }
        public List<int> grayCode(int n) 
    {
        var arr = new List<int>();
        arr.Add(0);
        for (int i=0; i<n; i++)
        {
            int inc = 1<<i;
            for(int j=arr.Count-1; j>=0; j--)
                arr.Add(arr[j] + inc);
        }
        return arr;
    }
}
