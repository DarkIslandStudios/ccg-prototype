using System.Collections.Generic;
using UnityEngine;

public abstract class RuntimeSet<T> : ScriptableObject
{
    public List<T> Cards = new List<T>();

    public void Add(T card)
    {
        // if (!Cards.Contains(card))
        Cards.Add(card);
    }

    public void Remove(T card)
    {
        if (Cards.Contains(card))
            Cards.Remove(card);
    }

}
