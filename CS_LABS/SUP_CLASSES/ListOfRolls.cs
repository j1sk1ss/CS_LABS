using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;

namespace CS_LABS.SUP_CLASSES;

public class ListOfRolls<T> : IEnumerable<T>
{
    private Roll<T> _head;
    private Roll<T> _tail;
    private int _size;

    public string Print() {
        var current = _head;
        var ans = "";
        while (current != null) {
            ans += current.Print() + "\n";
            current = current.Next;
        }
        return ans;
    }
    public void Add(Roll<T> data) {
        if (_head == null)
            _head = data;
        else {
            _tail.Next = data;
            data.Previous = _tail;
        }
        _tail = data;
        _size++;
    }
    public void AddFirst(Roll<T> data) {
        var temp = _head;
        data.Next = temp;
        _head = data;
        if (_size == 0)
            _tail = _head;
        else
            temp.Previous = data;
        _size++;
    }
    public bool Remove(List<T> data) {
        var current = _head;
        while (current != null) {
            if (current.Print() == data.Aggregate("", (s, t) => s + (t + " "))) {
                break;
            }
            current = current.Next;
        }
        if (current == null) {
            return false;
        }
        if(current.Next != null) {
            current.Next.Previous = current.Previous;
        }
        else {
            _tail = current.Previous;
        }
        if(current.Previous != null) {
            current.Previous.Next = current.Next;
        }
        else {
            _head = current.Next;
        }
        _size--;
        return true;
    }
    
    public int Count => _size;
    public bool IsEmpty => _size == 0;

    public void Clear() {
        _head = null;
        _tail = null;
        _size = 0;
    }
 
    public bool Contains(T[] data) {
        var current = _head;
        while (current != null) {
            if (current.Print() == data.Aggregate("", (s, t) => s + (t + " ")))
                return true;
            current = current.Next;
        }
        return false;
    }
    public IEnumerator<T> GetEnumerator() {
        var current = _head;
        while (current != null) {
            yield return current.Data[0];
            current = current.Next;
        }
    }

    IEnumerator IEnumerable.GetEnumerator() {
        return ((IEnumerable)this).GetEnumerator();
    }
}