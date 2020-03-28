using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Mod1Zad1
{
    class InfixToPostfix
    {
        static void Main(string[] args)
        {
            Stack stack = new Stack();
            string wyrazanie = "((((x^2)+((a-b)*z))+(e^2))^z)=";
            for(int i=0;i<wyrazanie.Length;i++)
            {
                if(wyrazanie[i]=='=')
                {
                    while(stack.Count>0)
                    {
                        Console.Write(stack.Pop());
                    }
                    break;
                }
                switch(wyrazanie[i])
                {
                    case ' ': break;
                    case '(': stack.Push('('); break;
                    case ')':

                        while (stack.Count > 0 && Convert.ToChar(stack.Peek()) != '(') 
                        {
                            Console.Write(stack.Pop());  
                        }
                            stack.Pop();
                        break;
                    case '+': case '-': case '*': case '/': case '^':
                        while (true)
                        {
                            if((stack.Count > 0) &&(coWieksze(wyrazanie[i]) < coWieksze(Convert.ToChar(stack.Peek()))) && Convert.ToChar(stack.Peek()) != '(' )
                            {
                                Console.Write(stack.Pop());
                            }
                            else
                            {
                                stack.Push(wyrazanie[i]);
                                break;
                            }
                            
                        }
                        break;
                    default: Console.Write(wyrazanie[i]); break;
                         

                }
            }
            Console.ReadKey();
        }
        static int coWieksze(char c)
        {
            switch(c)
            {
                case '+': return 1;
                    break;
                case '-': return 1;
                    break;
                case '*': return 2;
                    break;
                case '/': return 2;
                    break;
                case '^': return 3;
                    break;
                
            }
            return 4;
        }
    }  
}
