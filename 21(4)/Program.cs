using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _21_4_
{
    class Program
    {
        delegate int Summ(int m, int n);
        static void Main(string[] args)
        {
            Summ summ = new Summ(Sum);
            int result = summ.Invoke(1, 5);
            Console.WriteLine(result);
            result = summ.Invoke(1, 10);
            Console.WriteLine(result);
            result = summ.Invoke(1, 15);
            Console.WriteLine(result);
            Console.ReadLine();
        }
        static int Sum(int m, int n)
        {
            int sum = 0;
            for(int i = m;i<=n;i++)
            {
                sum += i;
            }
            return sum;
        }
    }
}
