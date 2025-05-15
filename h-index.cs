// 274. H-Index   
// https://leetcode.com/problems/h-index
// Medium 32.8%
// 582.4233625828314
// Submission: https://leetcode.com/submissions/detail/69482353/
// Runtime: 152 ms
// Your runtime beats 28.36 % of csharp submissions.

public class Solution {
    public int HIndex2(int[] citations) {
        Array.Sort(citations);
        Array.Reverse(citations);
                int i=0;
        while (i<citations.Length && citations[i]>=i+1)
            i++;
                    return i;
    }
        public int HIndex(int[] citations) 
    {
        int[] arr = new int[citations.Length+1];
        foreach (var c in citations)
        {
            if (c>=citations.Length) arr[citations.Length]++;
            else arr[c]++;
        }
                int tot =0;
        for (int i=citations.Length; i>=0; i--)
        {
            tot += arr[i];
            if (tot>=i) return i;
        }
        return 0;
    }
}
