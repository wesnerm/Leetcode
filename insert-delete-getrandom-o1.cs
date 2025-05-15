// 380. Insert Delete GetRandom O(1)   
// https://leetcode.com/problems/insert-delete-getrandom-o1
// Medium 38.9%
// 630.4094281838021
// Submission: https://leetcode.com/submissions/detail/92224186/
// Runtime: 248 ms
// Your runtime beats 93.55 % of csharp submissions.

public class RandomizedSet {
    Dictionary<int, int> hash = new Dictionary<int, int>();
    List<int> list = new List<int>();
    Random random = new Random();
    /** Initialize your data structure here. */
    public RandomizedSet() {
            }
        /** Inserts a value to the set. Returns true if the set did not already contain the specified element. */
    public bool Insert(int val) {
        if (hash.ContainsKey(val)) return false;
        hash.Add(val, list.Count);
        list.Add(val);
        return true;
    }
        /** Removes a value from the set. Returns true if the set contained the specified element. */
    public bool Remove(int val) {
        if (!hash.ContainsKey(val)) return false;
        var index = hash[val];
        hash.Remove(val);
        var lastVal = list[list.Count-1];
        if (index < list.Count-1)
        {
            list[index] = lastVal;
            hash[lastVal] = index;
        }
        list.RemoveAt(list.Count-1);
        return true;
    }
        /** Get a random element from the set. */
    public int GetRandom() {
        return list[random.Next(0,list.Count)];
    }
}
/**
 * Your RandomizedSet object will be instantiated and called as such:
 * RandomizedSet obj = new RandomizedSet();
 * bool param_1 = obj.Insert(val);
 * bool param_2 = obj.Remove(val);
 * int param_3 = obj.GetRandom();
 */
