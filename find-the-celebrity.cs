// 277. Find the Celebrity   
// https://leetcode.com/problems/find-the-celebrity
// Medium 35.3%
// 642.9655527345377
// Submission: https://leetcode.com/submissions/detail/70822366/
// Runtime: 308 ms
// Your runtime beats 56.60 % of csharp submissions.

/* The Knows API is defined in the parent class Relation.
      bool Knows(int a, int b); */
public class Solution : Relation {
    public int FindCelebrity(int n) {
        int candidate = 0;
        for (int i=1; i<n; i++)
            if (Knows(candidate, i))
                candidate = i;
                        for (int i=0; i<n; i++)
            if (i!=candidate && (!Knows(i, candidate) || Knows(candidate, i)))
                return -1;
                return candidate;
    }
}
