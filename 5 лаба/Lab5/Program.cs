using System;
using System.Collections.Generic;

public class AbstractList<T>
{
    private List<T> list = new List<T>();
    private int currentIndex = 0;

    public void Add(T item)
    {
        list.Add(item);
    }

    public T GetCurrent()
    {
        if (currentIndex < list.Count)
        {
            return list[currentIndex];
        }
        else
        {
            throw new IndexOutOfRangeException("Index is out of range.");
        }
    }

    public int GetCount()
    {
        return list.Count;
    }

    public bool MoveNext()
    {
        if (currentIndex < list.Count - 1)
        {
            currentIndex++;
            return true;
        }
        return false;
    }

    public bool MovePrevious()
    {
        if (currentIndex > 0)
        {
            currentIndex--;
            return true;
        }
        return false;
    }

    public void Reset()
    {
        currentIndex = 0;
    }
}

class Program
{
    static void Main(string[] args)
    {
        AbstractList<int> intList = new AbstractList<int>();

        intList.Add(1);
        intList.Add(2);
        intList.Add(3);
        intList.Add(4);

        Console.WriteLine("Текущий элемент: " + intList.GetCurrent());

        intList.MoveNext();
        Console.WriteLine("Текущий элемент: " + intList.GetCurrent());

        intList.MovePrevious();
        Console.WriteLine("Текущий элемент: " + intList.GetCurrent());

        Console.WriteLine("Количество элементов в списке: " + intList.GetCount());
    }
}
