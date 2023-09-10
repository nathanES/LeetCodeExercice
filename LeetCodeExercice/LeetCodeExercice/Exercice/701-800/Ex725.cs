using LeetCodeExercice.Common;

namespace LeetCodeExercice.Exercice._701_800;

public class Ex725
{
    public Ex725()
    {
        ListNode i1 = new ListNode(1)
        {
    next = new ListNode(2)
        {
                next = new ListNode(3)
                }
            };
            ListNode[] o1 = new ListNode[5]
            {
                new ListNode(1),
                new ListNode(2),
                new ListNode(3),
                null,null
            };
            if (SplitListToPartsCorrection(i1,5) != o1)
                throw new Exception("ex 1 : faux");
            
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
                                {
                                    next = new ListNode(7)
                                    {
                                        next = new ListNode(8)
                                        {
                                            next = new ListNode(9)
                                            {
                                                next = new ListNode(10)
                                            }
                                        }
                                    }
                                }
                            }
                        }
                    }
                }
            };
            ListNode[] o2 = new ListNode[3]
            {
                new ListNode(1)
                {
                    next = new ListNode(2)
                    {
                        next = new ListNode(3)
                        {
                            next = new ListNode(4)
                        }
                    }
                },
                new ListNode(5)
                {
                    next = new ListNode(6)
                    {
                        next = new ListNode(7)
                    }
                },
                new ListNode(8)
                {
                    next = new ListNode(9)
                    {
                        next = new ListNode(10)
                    }
                }
            };
            
            if (SplitListToPartsCorrection(i2,3) != o2)
                throw new Exception("ex 2 : faux");
    }
    
    
    public ListNode[] SplitListToPartsCorrection(ListNode head, int k) {
        int length = 0;
        ListNode current = head;
        List<ListNode> parts = new List<ListNode>();

        while (current != null) {
            length++;
            current = current.next;
        }

        int base_size = length / k, extra = length % k;
        current = head;

        for (int i = 0; i < k; i++) {
            int part_size = base_size + (extra > 0 ? 1 : 0);
            ListNode part_head = null, part_tail = null;

            for (int j = 0; j < part_size; j++) {
                if (part_head == null) {
                    part_head = part_tail = current;
                } else {
                    part_tail.next = current;
                    part_tail = part_tail.next;
                }

                if (current != null) {
                    current = current.next;
                }
            }

            if (part_tail != null) {
                part_tail.next = null;
            }

            parts.Add(part_head);
            extra = System.Math.Max(extra - 1, 0);
        }

        return parts.ToArray();
    }

}