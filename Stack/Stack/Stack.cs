using System;
using System.Collections.Generic;
using System.Text;

namespace DataStructures
{
    public class Stack<T>
    {
        Node<T> head = null;
        Node<T> tail = null;
        public void push(T data)
        {
            Node<T> node = new Node<T>();
            node.data = data;
            node.next = head;
            if (tail == null)
            {
                tail = node;
            }
            head = node;
        }

        public T pop()
        {
            if (head == null)
            {
                Console.WriteLine("Stack was empty");
            }
            Node<T> current = head;
            head = head.next;
            return current.data;
            
        }

        public void peek()
        {
            if (head == null)
            {
                Console.WriteLine("Stack was empty");
            }
            Console.WriteLine(head.data);
        }
    }
}
