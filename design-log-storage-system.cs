// 635. Design Log Storage System   
// https://leetcode.com/problems/design-log-storage-system
// Medium 46.5%
// 327.63444229410226
// Submission: https://leetcode.com/submissions/detail/111481056/
// Runtime: 769 ms
// Your runtime beats 15.09 % of csharp submissions.

public class LogSystem {
    SortedSet<string> set = new SortedSet<string>();
    Dictionary<string, List<int>> dict = new Dictionary<string, List<int>>();
    public LogSystem() {
            }
        public void Put(int id, string timestamp) {
        if (!dict.ContainsKey(timestamp))
        {
            dict[timestamp] = new List<int>();
            set.Add(timestamp);
        }
        dict[timestamp].Add(id);
    }
        public IList<int> Retrieve(string s, string e, string gra) {
                string startmask = "0000:00:00:00:00:00";
        string endmask = "9999:99:99:99:99:99";
                int del = 0;
        switch (gra.ToLower())
        {
            case "year":
                del = 15;
                break;            
            case "month":
                del = 12;
                break;            
            case "day":
                del = 9;
                break;            
            case "hour":
                del=6;
                break;            
            case "minute":
                del=3;
                break;            
        }
                var start = s.Substring(0, s.Length-del) + startmask.Substring(s.Length-del);
        var end   = e.Substring(0, e.Length-del) + endmask.Substring(e.Length-del);
        var list = new List<int>();
        var view = set.GetViewBetween(start,end);
        foreach(var v in view)
            list.AddRange(dict[v]);
        return list;
    }
}
/**
 * Your LogSystem object will be instantiated and called as such:
 * LogSystem obj = new LogSystem();
 * obj.Put(id,timestamp);
 * IList<int> param_2 = obj.Retrieve(s,e,gra);
 */
