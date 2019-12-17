using System;
using DataStructures;

namespace PostFixCalculator
{
    class Program
    {
        //5 6 7 * + 1 - 
        static void Main(string[] args)
        {
            string postFixExpression = Console.ReadLine();
            string[] s = postFixExpression.Split(' ');
            Stack<int> stack = new Stack<int>();
            int result;
            foreach (var item in s)
            {
                int right;
                int left;
                switch (item)
                {
                    case "+":
                        right = Convert.ToInt32(stack.pop());
                        left = Convert.ToInt32(stack.pop());
                        result = left + right;
                        stack.push(result);
                        break;
                    case "-":
                        right = Convert.ToInt32(stack.pop());
                        left = Convert.ToInt32(stack.pop());
                        result = left - right;
                        stack.push(result);
                        break;
                    case "*":
                        right = Convert.ToInt32(stack.pop());
                        left = Convert.ToInt32(stack.pop());
                        result = left * right;
                        stack.push(result);
                        break;
                    case "/":
                        right = Convert.ToInt32(stack.pop());
                        left = Convert.ToInt32(stack.pop());
                        result = left / right;
                        stack.push(result);
                        break;
                    default:
                        stack.push(Convert.ToInt32(item));
                        break;
                }
            }
            Console.WriteLine(stack.pop());
        }
    }
}
