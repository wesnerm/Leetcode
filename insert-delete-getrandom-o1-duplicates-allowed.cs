// 381. Insert Delete GetRandom O(1) - Duplicates allowed   
// https://leetcode.com/problems/insert-delete-getrandom-o1-duplicates-allowed
// Hard 28.7%
// 380.5056445478247
// Submission: https://leetcode.com/submissions/detail/70870794/
// Runtime: 171 ms
// Your runtime beats 16.47 % of java submissions.

public class RandomizedCollection {
    List<Integer> list; // stores the numbers that are currently in the collection
    Map<Integer, Set<Integer>> map; // stores the value and the corresponding     multiple indexes where we can find the number. The 
        usage of set is due to the O(1) requirement
    java.util.Random rand = new java.util.Random();
    /** Initialize your data structure here. */
    public RandomizedCollection() {
        list = new ArrayList<>();
        map = new HashMap<>();
    }
        /** Inserts a value to the collection. Returns true if the collection did not already contain the specified element. */
    public boolean insert(int val) {
        boolean res = false;
        if (!map.containsKey(val)) {
            map.put(val, new HashSet<Integer>());
            res = true;
        }
        map.get(val).add(list.size());
        list.add(val);
        return res;
    }
        /** Removes a value from the collection. Returns true if the collection contained the specified element. */
    public boolean remove(int val) {
        if (!map.containsKey(val)) return false;
        int idx = map.get(val).iterator().next();
        // list.remove(idx); // here if we use remove(), the complexity can be up to O(n), which is not desired
        if (list.get(idx) != list.get(list.size()-1)) { // if the number to be removed is not equal to the last number in the list
            int last = list.get(list.size()-1);
            list.set(idx, last);
            map.get(last).remove(list.size()-1);
            map.get(last).add(idx);
            map.get(val).remove(idx);
        } else {
            map.get(val).remove(list.size()-1);
        }
        list.remove(list.size()-1);
        if (map.get(val).size() == 0) map.remove(val);
        return true;
    }
        /** Get a random element from the collection. */
    public int getRandom() {
        return list.get(rand.nextInt(list.size()));
    }
}
/**
 * Your RandomizedCollection object will be instantiated and called as such:
 * RandomizedCollection obj = new RandomizedCollection();
 * boolean param_1 = obj.insert(val);
 * boolean param_2 = obj.remove(val);
 * int param_3 = obj.getRandom();
 */
