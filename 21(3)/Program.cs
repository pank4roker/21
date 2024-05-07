using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _21_3_
{
    class Program
    {
        delegate double Ager(int m,int n);
        static void Main(string[] args)
        {
            Ager ager = new Ager(Average);
            double res = ager.Invoke(1, 5);
            Console.WriteLine(res);
            res = Average(1,10);
            Console.WriteLine(res);
            res = Average(1, 15);
            Console.WriteLine(res);
            Console.ReadLine();
        }
        static double Average(int m, int n)
        {
            double sum = 0;
            double count = 0;
           for(int i = m; i <= n; i++)
           {
                sum += i;
                count++;
           }
           return sum / count;
        }
    }
}
