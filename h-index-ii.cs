// 275. H-Index II   
// https://leetcode.com/problems/h-index-ii
// Medium 34.0%
// 444.66095900649333
// Submission: https://leetcode.com/submissions/detail/69659990/
// Runtime: 168 ms
// Your runtime beats 40.54 % of csharp submissions.

public class Solution {
     public int HIndex2(int[] citations) {
        Array.Reverse(citations);
                int i=0;
        while (i<citations.Length && citations[i]>=i+1)
            i++;
                    return i;
    }
     public int HIndex3(int[] citations) {
        Array.Reverse(citations);
        int left = 0;
        int right = citations.Length-1;
        while (left<=right)
        {
            int mid = (left+right)/2;
            if (citations[mid]>mid)
                left = mid+1;
            else
                right = mid-1;
        }    
        return left;
    } 
     public int HIndex(int[] citations) {
        int len = citations.Length;
        int left = 0;
        int right = citations.Length-1;
        while (left<=right)
        {
            int mid = (left+right)/2;
            if (citations[len-1-mid]> mid ) // >= len-mid
                left = mid+1;
            else
                right = mid-1;
        }    
        return left;
    } 
    }
