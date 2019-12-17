using System;
using System.Collections.Generic;
using System.Text;

namespace StackusingArray
{
    class Stack<T>
    {
        T[] arr = new T[0];
        int size = 0;
        public void push(T data)
        {
            size++;
            T[] newArray = new T[size];
            arr.CopyTo(newArray, 0);
            newArray[size - 1] = data;
            arr = newArray;
        }

        public void pop()
        {
            size--;
            Console.WriteLine(arr[size]);
        }
    }
}
