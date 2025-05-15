// 609. Find Duplicate File in System   New
// https://leetcode.com/problems/find-duplicate-file-in-system
// Medium 52.7%
// 237.48546157931267
// Submission: https://leetcode.com/submissions/detail/105458351/
// Runtime: 675 ms
// Your runtime beats 37.25 % of csharp submissions.

public class Solution {
    public IList<IList<string>> FindDuplicate(string[] paths) {
                var dict = new  Dictionary<string, IList<string>>();
        foreach(var info in paths)
        {
            var split = info.Split();
            if (split.Length==0) continue;
                        var path = split[0];
            for (int j=1; j<split.Length; j++)
            {
                var s = split[j];
                int i = s.IndexOf('(');
                var file = s.Substring(0,i);
                var content = s.Substring(i+1, s.Length-(i+1)-1);
                //Console.WriteLine(file +"  --  " + content);
                                if (!dict.ContainsKey(content)) dict[content] = new List<string>();
                dict[content].Add(path+"/"+file);
            }
        }
        return dict.Values.Where(list=>list.Count>1).ToList();        
    }
}
