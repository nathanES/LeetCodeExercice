namespace LeetCodeExercice.Exercice._201_300;

public class Ex225
{
    public Ex225()
    {
        MyStack obj = new MyStack();
        obj.Push(1);
        obj.Push(2);
        var t = obj.Top();
        var p = obj.Pop();
        var o = obj.Empty();
    }
}
public class MyStack
{
    private Queue<int> q;

    public MyStack()
    {
        q = new Queue<int>();
    }

    public void Push(int x)
    {
        q.Enqueue(x);
        for (int i = 0; i < q.Count - 1; i++)
        {
            q.Enqueue(q.Dequeue());
        }
    }

    public int Pop()
    {
        return q.Dequeue();
    }

    public int Top()
    {
        return q.Peek();
    }

    public bool Empty()
    {
        return q.Count == 0;
    }
}