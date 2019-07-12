using System;

namespace Params
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] x = new int [] {1,3,4,4,4,2};
            Sum(x);
            Sum(2, 3, 4, 5, 67, 1);
            Console.ReadKey();
        }
        static void Sum(params int[] x)
        {
            int sum = 0;
            foreach (int s in x) 
                sum += s;

            Console.WriteLine( sum);
        }
    }
}
