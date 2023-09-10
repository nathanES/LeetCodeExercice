using LeetCodeExercice.Common;

namespace LeetCodeExercice.Exercice._801_900;

public class Ex876
{
    public Ex876()
    {
        ListNode i1 = new ListNode(1)
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
        var t1 = MiddleNode(i1);
        ListNode i2 = new ListNode(1)
        {
            next = new ListNode(2)
            {
                next = new ListNode(3)
                {
                    next = new ListNode(4)
                    {
                        next = new ListNode(5)
                        {
                            next = new ListNode(6)
                        }
                    }
                }
            }
        };
        var t2 = MiddleNode(i2);
    }
    public ListNode MiddleNode(ListNode head)
    {
        ListNode end = head;
        ListNode middle = head;
            
        while (end != null&& end.next !=null)
        {
            end = end.next.next;
            middle = middle.next;
        }

        return middle;

    }
    public ListNode MiddleNodeMoinsBien(ListNode head)
    {
        List<ListNode> listNodes = new List<ListNode>();
        while (head != null)
        {
            listNodes.Add(head);
            head = head.next;
        }
        return listNodes[listNodes.Count/2];

    }

    
}