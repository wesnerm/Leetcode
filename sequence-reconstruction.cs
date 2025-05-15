// 444. Sequence Reconstruction   
// https://leetcode.com/problems/sequence-reconstruction
// Medium 19.7%
// 106.72323524744385
// Submission: https://leetcode.com/submissions/detail/101884954/
// Runtime: 276 ms
// Your runtime beats 87.50 % of csharp submissions.

public class Solution {
        public bool SequenceReconstruction(int[] org, IList<IList<int>> seqs) {
        int[] check = new int[org.Length+1];
        bool[] flags = new bool[org.Length+1];
        bool[] flags2 = new bool[org.Length+1];
                if (seqs.Count == 0)
            return false;
        for (int i=0; i<org.Length; i++)
            check[org[i]] = i;
            int matches = 0;
        int matches2 = 0;
        for (int i=0; i<seqs.Count; i++)
        {
            for (int j=0; j<seqs[i].Count; j++)
            {
                var c = seqs[i][j];
                if (seqs[i][j]<1||seqs[i][j]>org.Length) return false;                
                                if (flags2[c]==false)
                {
                    flags2[c] = true;    
                    matches2++;
                }
                                if (j==0) continue;
                if (check[seqs[i][j-1]] >= check[seqs[i][j]] )
                    return false;
                if (check[seqs[i][j-1]]+1 == check[seqs[i][j]] )
                {
                    if (flags[seqs[i][j]] == false)
                    {
                        flags[seqs[i][j]] = true;
                        matches++;
                    }
                }
            }
        }
        return matches >= org.Length-1 && matches2==org.Length;
    }
    }
