using System;

namespace Uri1143
{
    class Program
    {
        static void Main(string[] args)
        {
            int n;
            double a, b, c;
            a = 1;
            b = 1;
            c = 1;

            n = int.Parse(Console.ReadLine());

            while(n>1000)
            {
                n = int.Parse(Console.ReadLine());
            }

            for (double i = 1; i <= n; i++)
            {
                
                a = i;
                b = Math.Pow(i, 2);
                c = Math.Pow(i,3);
                Console.WriteLine(a + " " + b + " " + c);
            }
        }
    }
}
