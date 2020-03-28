using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Kolejka
{
    class Program
    {
        public double[] elementss;

        static void Main(string[] args)
        {
            Kolejka Q = new Kolejka(10);


            Q.enqueue(10);
            Q.enqueue(13);
            Q.enqueue(345);
            Q.enqueue(13);
            Q.enqueue(10.11);
            Q.enqueue(21398);
            Q.enqueue(124);
            Q.enqueue(2130);
            Q.enqueue(9.9999);
            Q.enqueue(9.6464);

            Q.printQueue();
            Q.dequeue();
            Q.findElements(13);
            Console.ReadKey();
        }
    }

    class Kolejka
    {
        private double[] elements;
        private int head;
        private int tail;
        private int max;

        public Kolejka(int size)
        {
            elements = new double[size];
            head = 0;
            tail = -1;
            max = size;
        }
        public void enqueue(double item)
        {
            if (tail == max - 1)
            {
                Console.WriteLine("Kolejka przepłniona");
                return;
            }
            else
            {
                elements[++tail] = item;
            }

        }
        public double dequeue()
        {
            if (head == tail + 1)
            {
                Console.WriteLine("Kolejka jest pusta");
                return -1;
            }
            else
            {
                Console.WriteLine(elements[head] + " wyjęty z kolejki");
                double p = elements[head++];
                Console.WriteLine();
                Console.WriteLine("Początek kolejki to " + elements[head]);
                Console.WriteLine("Koniec kolejki to " + elements[tail]);
                return p;
            }

        }
        public void printQueue()
        {
            if (head == tail + 1)
            {
                Console.WriteLine("Kolejka jest pusta");
            }
            else
            {
                for (int i = head; i <= tail; i++)
                {
                    Console.WriteLine(elements[i] + " należą do kolejki");
                }
            }

        }
        public void findElements(double element)
        {
            for (int i = 0; i <= elements.Length - 1; i++)
            {
                if (elements[i] == element)
                {
                    Console.WriteLine("Szukany " + element + " znajduje się na pozycji " + i);
                }
            }
        }

    }
}
