using LeetCodeExercice.Common;

namespace LeetCodeExercice.Exercice._1_100;

public class Ex92
{
    public Ex92()
    {
        var i1 = new ListNode(1)
        {
            next = new ListNode(2)
            {
                next = new ListNode(3)
                {
                    next = new ListNode(4)
                    {
                        next = new ListNode(5)
                    }
                }
            }
        };
        var o1 = new ListNode(1)
        {
            next = new ListNode(4)
            {
                next = new ListNode(3)
                {
                    next = new ListNode(2)
                    {
                        next = new ListNode(5)
                    }
                }
            }
        };
        if (ReverseBetweenCorrection(i1,2,4) != o1)
            throw new Exception("ex 1 : faux");
    }
    public ListNode ReverseBetweenCorrection(ListNode head, int left, int right)
    {
        if (head == null || left == right) return head;
        
        ListNode dummy = new ListNode(0);
        dummy.next = head;
        ListNode prev = dummy;
        
        for (int i = 0; i < left - 1; ++i) {
            prev = prev.next;
        }
        
        ListNode current = prev.next;
        
        for (int i = 0; i < right - left; ++i) {
            ListNode nextNode = current.next;
            current.next = nextNode.next;
            nextNode.next = prev.next;
            prev.next = nextNode;
        }
        
        return dummy.next;
    }

}