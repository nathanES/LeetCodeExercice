namespace LeetCodeExercice.Exercice._701_800;

public class Ex706
{
    public Ex706()
    {
        
    }
}
public class MyHashMap
{
    private ListNode[] map;

    public MyHashMap()
    {
        map = new ListNode[1000];
    }

    private int Hash(int key)
    {
        return key % map.Length;
    }

    public void Put(int key, int value)
    {
        int index = Hash(key);
        ListNode current = map[index];

        while (current != null)
        {
            if (current.Key == key)
            {
                current.Value = value;
                return;
            }
            current = current.Next;
        }

        map[index] = new ListNode(key, value, map[index]);
    }

    public int Get(int key)
    {
        int index = Hash(key);
        ListNode current = map[index];

        while (current != null)
        {
            if (current.Key == key)
            {
                return current.Value;
            }
            current = current.Next;
        }

        return -1;
    }

    public void Remove(int key)
    {
        int index = Hash(key);
        ListNode current = map[index];
        ListNode prev = null;

        while (current != null)
        {
            if (current.Key == key)
            {
                if (prev != null)
                {
                    prev.Next = current.Next;
                }
                else
                {
                    map[index] = current.Next;
                }
                return;
            }
            prev = current;
            current = current.Next;
        }
    }
}
public class ListNode
{
    public int Key { get; set; }
    public int Value { get; set; }
    public ListNode Next { get; set; }

    public ListNode(int key = -1, int value = -1, ListNode next = null)
    {
        Key = key;
        Value = value;
        Next = next;
    }
}