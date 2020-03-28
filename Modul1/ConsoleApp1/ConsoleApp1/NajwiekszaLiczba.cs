using System;

namespace ConsoleApp1
{
    class NajwiekszaLiczba
    {
        static void Main(string[] args)
        {
            double[] array = { 1.4 , 2.2, 33, 44, 51, 6234 };
            Console.WriteLine(najLiczba(array));
        }
        public static double najLiczba(double[] dane)
        {
            double max = dane[0];
            for(int i =0;i<dane.Length;i++)
            {
                if(dane[i]>max)
                {
                    max = dane[i];
                }
            }
            return max;
        }
    }
}
