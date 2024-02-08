using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public abstract class RuntimeSet<T> : ScriptableObject
{

    // This seems like it's an implementation of the Set data structure
    public List<T> Items = new List<T>();
    public void Add(T t) { if(!Items.Contains(t)) Items.Add(t); }
    public void Remove(T t) { if (Items.Contains(t)) Items.Remove(t);}
}
