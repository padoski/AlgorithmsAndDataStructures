using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    class PostfixToInfix
    {
        static void Main(string[] args)
        {
            Stack stack = new Stack();
            string wyrazenie = "x2^ab-z*+e2^+z^";
            string temp1;
            string temp2;
            for (int i = 0; i < wyrazenie.Length; i++)
            {
                switch (wyrazenie[i])
                {
                    case '+':
                        temp1 = Convert.ToString(stack.Pop());
                        temp2 = Convert.ToString(stack.Pop());
                        stack.Push("(" + temp2 + " + " + temp1 + ")");
                        break;
                    case '-':
                        temp1 = Convert.ToString(stack.Pop());
                        temp2 = Convert.ToString(stack.Pop());
                        stack.Push("(" + temp2 + " - " + temp1 + ")");
                        break;
                    case '*':
                        temp1 = Convert.ToString(stack.Pop());
                        temp2 = Convert.ToString(stack.Pop());
                        stack.Push("(" + temp2 + " * " + temp1 + ")");
                        break;
                    case '/':
                        temp1 = Convert.ToString(stack.Pop());
                        temp2 = Convert.ToString(stack.Pop());
                        stack.Push("(" + temp2 + " / " + temp1 + ")");
                        break;
                    case '^':
                        temp1 = Convert.ToString(stack.Pop());
                        temp2 = Convert.ToString(stack.Pop());
                        stack.Push("(" + temp2 + " ^ " + temp1 + ")");
                        break;
                    default: stack.Push(wyrazenie[i]);
                        break;
                }
            }
            foreach (Object obj in stack)
                Console.Write(obj);
            Console.ReadKey();
        }
    }
}
