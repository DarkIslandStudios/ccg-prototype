using System.Collections.Generic;
using UnityEngine;

public abstract class RuntimeStack<T> : ScriptableObject
{
    public Stack<T> Items = new Stack<T>();

    public void AddItem(T item)
    {
        Debug.Log("Adding item to stack " + item);
        Items.Push(item);
    }

    public T PopItem()
    {
        Debug.Log("Popping item from stack");
        return Items.Pop();
    }

}
