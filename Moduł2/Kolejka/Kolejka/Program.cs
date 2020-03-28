using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Kolejka
{
    class Program
    {

        static void Main(string[] args)
        {
            Kolejka Q = new Kolejka(5);

            
            Q.Enqueue(10);
            Q.Enqueue(13);
            Q.Enqueue(345);
            Q.Enqueue(13);
            Console.WriteLine("Ilość ludzi w kolejce to " +Q._counter);
            Q.PrintQueue();
            Q.PrintAllArray();
            Q.Dequeue();
            Console.WriteLine("Ilość ludzi w kolejce to " + Q._counter);
            Q.PrintQueue();
            Q.PrintAllArray();
            Q.Enqueue(15);
            Q.Enqueue(121);
            Q.PrintQueue();
            Q.PrintAllArray();
            Q.Dequeue();
            Q.Dequeue();
            Q.PrintQueue();
            Q.PrintAllArray();
            Q.Enqueue(1);
            Q.Enqueue(2);
            Q.PrintQueue();
            Q.PrintAllArray();
            Console.ReadKey();
        }
    }

    class Kolejka
    {
        public double[] _elements { get; set; }
        public int _head { get; set; }
        public int _tail { get; set; }
        public int _counter { get; set; }

        public Kolejka(int size)
        {
            _elements = new double[size];
            _head = _elements.Length-1;
            _tail = 0;
            _counter = 0;
        }
        public void Enqueue(double item)
        {
            if(_tail-1!=_head)
            {
                _counter++;
                if (_tail == 0)
                {
                    _tail = _elements.Length - 1;
                    _elements[_tail] = item;
                }
                else
                {
                    _tail--;
                    _elements[_tail] = item;
                }
            }
            else
            {
                Console.WriteLine("Kolejka jest przepełniona");
            }
            
            
        }
        public void Dequeue()
        {
            _counter--;
            _elements[_head] = 0;
            if (_head == 0)
            {
                _head = _elements.Length - 1;
            }
            else
            {
                _head--;
            }
            
        }
        public void PrintQueue()
        {
            Console.WriteLine("Kolejka wyświetlana jest od góry do dołu-pierwsza osoba w kolejce jest na samym dole ");
            int temp = _counter;
            for(int i = _tail; i < _tail + _counter; i++)
            {
                Console.WriteLine(_elements[i]);
                if (i==_elements.Length-1)
                {
                    for(int j=0;j< _tail + _counter - 1-i;j++)
                    {
                        Console.WriteLine(_elements[j]);
                    }
                    break;
                }
                
            }
            _counter = temp;
        }
        public void FindElements(double element)
        {
            int temp = _counter;
            for (int i=_tail;i< _tail + _counter; i++)
            {
                if(_elements[i]==element)
                {
                    Console.WriteLine(" Element " + element + " znajduje się na pozycji " + i + " w tablicy");
                }
                if(i==_elements.Length-1)
                {
                    for(int j=0; j<_counter-1-i;j++)
                    {
                        if (_elements[j] == element)
                        {
                            Console.WriteLine(" Element " + element + " znajduje się na pozycji " + j + " w tablicy");
                        }
                    }
                    break;
                }
            }
            _counter = temp;
        }
        public void PrintAllArray()
        {
            Console.WriteLine("Wyświetlane są wszystkie elementy tablicy ");
            for (int i = 0; i < _elements.Length; i++)
            {
                Console.WriteLine(_elements[i]);
            }
        }
    }
}
