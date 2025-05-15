// 72. Edit Distance   
// https://leetcode.com/problems/edit-distance
// Hard 31.3%
// 1013.9975693803647
// Submission: https://leetcode.com/submissions/detail/70690427/
// Runtime: 140 ms
// Your runtime beats 20.00 % of csharp submissions.

public class Solution {
       public  int MinDistance(string source, string target)
      {
              int sourceLength = source.Length;
              int targetLength = target.Length;
              // Get Lengths
              if ( targetLength == 0) return sourceLength;
              var dist = new int [targetLength];
              // Initialize array
              for ( int j = 0; j < targetLength; j ++)
                   dist[ j] = j+1;
              // Perform edit distance tests
              for ( int i = 0; i < sourceLength; i ++)
             {
                    var distpp = i ; // dist[i-1, j-1] at j=0
                    var distnp = i + 1; // dist[i, j-1] at j=0
                    char ch1 = source[ i ];
                    for ( int j = 0; j < targetLength; j ++)
                   {
                           int distpn = dist[ j]; // dist[i-1, j]
                           int distnn = distpp ;
                           if (ch1 != target[ j ]) distnn ++;
                           distnn = Math.Min(distnn, distnp + 1); // deletion
                           distnn = Math.Min(distnn, distpn + 1); // insertion
                           // Next loop
                           distpp = distpn;
                           distnp = distnn ;
                          dist[ j] = distnn ; // dist[i, j]
                   }
             }
              return dist[ targetLength - 1];
      }
}
