// 165. Compare Version Numbers   
// https://leetcode.com/problems/compare-version-numbers
// Medium 19.8%
// 808.2982043580075
// Submission: https://leetcode.com/submissions/detail/70031252/
// Runtime: 128 ms
// Your runtime beats 15.69 % of csharp submissions.

public class Solution {
    public int CompareVersion(string version1, string version2) {
        var split1 = version1.Split('.');
        var split2 = version2.Split('.');
                int i=0;
        while (i < split1.Length || i < split2.Length)
        {
            int v1 = i<split1.Length ? int.Parse(split1[i]) : 0 ;
            int v2 = i<split2.Length ? int.Parse(split2[i]) : 0 ;
            int cmp = v1.CompareTo(v2);
            if (cmp != 0)
                return cmp;
            i++;
        }
        return 0;
    }
}
