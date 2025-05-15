// 220. Contains Duplicate III   
// https://leetcode.com/problems/contains-duplicate-iii
// Medium 19.2%
// 891.0528977359386
// Submission: https://leetcode.com/submissions/detail/70389425/
// Runtime: 176 ms
// Your runtime beats 22.58 % of csharp submissions.

public class Solution {
    public bool ContainsNearbyAlmostDuplicate2(int[] nums, int k, int t)
    {
        if (t<0)
            return false;
                    var set  = new SortedSet<long>();
        for (int i=0; i<nums.Length; i++)
        {
            if (i>k) set.Remove(nums[i-k-1]);
            int n = nums[i];
            if (set.GetViewBetween(n-(long)t, n+(long)t).Count>0)
                return true;            
            set.Add(n);
        }
        return false;
    }
    public bool ContainsNearbyAlmostDuplicate(int[] nums, int k, int t)
    {
        if (k<1 || t<0)
            return false;
                const long off = int.MinValue;
        long d = t==0 ? 1 : t;
        var dict = new Dictionary<long, long>();
        for (int i=0; i<nums.Length; i++)
        {
            long n = (long)nums[i] - off;
            long b = n/d;
            if (i>k) dict.Remove((nums[i-k-1]-off)/d);
            if (dict.ContainsKey(b) 
                || dict.ContainsKey(b-1) && n - dict[b-1] <=t
                || dict.ContainsKey(b+1) && dict[b+1] - n <=t)
                return true;
            //if (dict.Count >=k) dict.Remove((nums[i-k]-off)/(t+1));
            dict[b] = n;
        }
        return false;
    }
}
