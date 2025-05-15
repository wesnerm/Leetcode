// 146. LRU Cache   
// https://leetcode.com/problems/lru-cache
// Hard 17.2%
// 1522.4548110367912
// Submission: https://leetcode.com/submissions/detail/71737663/
// Runtime: 532 ms
// Your runtime beats 24.76 % of csharp submissions.

    public class LRUCache
    {
        public struct Entry
        {
            public int key;
            public int value;
        }
        public LinkedList<Entry> list = new LinkedList<Entry>();
        public Dictionary<int, LinkedListNode<Entry>> hash = new Dictionary<int, LinkedListNode<Entry>>();
        public int capacity;
        public LRUCache(int capacity)
        {
            this.capacity = capacity;
        }
        public int Get(int key)
        {
            LinkedListNode<Entry> result;
            if (!hash.TryGetValue(key, out result))
                return -1;
            list.Remove(result);
            list.AddFirst(result);
            return result.Value.value;
        }
        public void Set(int key, int value)
        {
            LinkedListNode<Entry> result;
            if (hash.TryGetValue(key, out result))
                list.Remove(result);
            hash[key] = list.AddFirst(new Entry {key = key, value = value});
            while (hash.Count > capacity)
            {
                var node = list.Last;
                list.Remove(node);
                hash.Remove(node.Value.key);
            }
        }
                        /*
        int capacity;
        Node head;
        Dictionary<int, Node> map;
        class Node
        {
            public int key;
            public int value;
            public Node previous;
            public Node next;
        }
        public LRUCache(int capacity)
        {
            map = new Dictionary<int, Node>(capacity+1);
            head = new Node();
            head.previous = head;
            head.next = head;
            this.capacity = capacity;
        }
        public int Get(int key)
        {
            Node node;
            if (!map.TryGetValue(key, out node))
                return -1;
            Remove(node);
            Attach(node);
            return node.value;
        }
        public void Set(int key, int value)
        {
            Node node;
            if (map.TryGetValue(key, out node))
                Remove(node);
            else
                node = new Node { key = key };
            map[key] = node;
            node.value = value;
            Attach(node);
            if (map.Count > capacity)
            {
                Node removeNode = head.next;
                map.Remove(removeNode.key);
                Remove(removeNode);
            }
        }
        private void Remove(Node node)
        {
            node.previous.next = node.next;
            node.next.previous = node.previous;
            node.next = null;
            node.previous = null;
        }
        private void Attach(Node node)
        {
            node.previous = head.previous;
            node.next = head;
            node.previous.next = node;
            node.next.previous = node;
        }
        */
    }
