using LeetCodeExercice.Common;

namespace LeetCodeExercice.Exercice._101_200;

public class Ex141
{
    public Ex141()
    {
        var i1 = new ListNode(3)
        {
            next = new ListNode(2)
            {
                next = new ListNode(0)
                {
                    next = new ListNode(-4)
                }
            }
        };
        if (!HasCycle(i1))
            throw new Exception("ex 1 : faux");
            
        var i2 = new ListNode(1)
        {
            next = new ListNode(2)
        };
        if (!HasCycle(i2))
            throw new Exception("ex 2 : faux");
            
        var i3 = new ListNode(1);
        if (HasCycle(i3))
            throw new Exception("ex 3 : faux");

    }
    public bool HasCycle(ListNode head)
    {
        ListNode slow_pointer = head, fast_pointer = head;
        while (fast_pointer != null && fast_pointer.next != null) {
            slow_pointer = slow_pointer.next;
            fast_pointer = fast_pointer.next.next;
            if (slow_pointer == fast_pointer) {
                return true;
            }
        }
        return false;
    }

}