// 352. Data Stream as Disjoint Intervals   
// https://leetcode.com/problems/data-stream-as-disjoint-intervals
// Hard 39.7%
// 448.41305565655165
// Submission: https://leetcode.com/submissions/detail/71535711/
// Runtime: 224 ms
// Your runtime beats 27.05 % of java submissions.

public class SummaryRanges {
    TreeMap<Integer, Interval> tree;
    public SummaryRanges() {
        tree = new TreeMap<>();
    }
    public void addNum(int val) {
        if(tree.containsKey(val)) return;
        Integer l = tree.lowerKey(val);
        Integer h = tree.higherKey(val);
        if(l != null && h != null && tree.get(l).end + 1 == val && h == val + 1) {
            tree.get(l).end = tree.get(h).end;
            tree.remove(h);
        } else if(l != null && tree.get(l).end + 1 >= val) {
            tree.get(l).end = Math.max(tree.get(l).end, val);
        } else if(h != null && h == val + 1) {
            tree.put(val, new Interval(val, tree.get(h).end));
            tree.remove(h);
        } else {
            tree.put(val, new Interval(val, val));
        }
    }
    public List<Interval> getIntervals() {
        return new ArrayList<>(tree.values());
    }
}
