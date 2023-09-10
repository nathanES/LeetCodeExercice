using LeetCodeExercice.Common;

namespace LeetCodeExercice.Exercice._101_200;

public class Ex138
{
    public Ex138()
    {
        var t1 = CopyRandomList(new Node(1));
        var t2 = CopyRandomList(new Node(2));
        var t3 = CopyRandomList(new Node(3));
    }
    public Node CopyRandomList(Node head) {
        if (head == null) return null;
        
        Dictionary<Node, Node> oldToNew = new Dictionary<Node, Node>();
        
        Node curr = head;
        while (curr != null) {
            oldToNew[curr] = new Node(curr.val);
            curr = curr.next;
        }
        
        curr = head;
        while (curr != null) {
            oldToNew[curr].next = curr.next != null ? oldToNew[curr.next] : null;
            oldToNew[curr].random = curr.random != null ? oldToNew[curr.random] : null;
            curr = curr.next;
        }
        
        return oldToNew[head];
    }

}