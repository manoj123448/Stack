using System;

namespace StackusingArray
{
    class Program
    {
        static void Main(string[] args)
        {
            Stack<int> stack = new Stack<int>();
            stack.push(1);
            stack.push(2);
            stack.push(3);

            for (int i = 0; i < 3; i++)
            {
                stack.pop();
            }
        }
    }
}
