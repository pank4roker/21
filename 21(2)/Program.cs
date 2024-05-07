using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;

namespace _21_2_
{
    class Program
    {
        delegate int Func(int a, int b);
        static void Main(string[] args)
        {
            Func func = new Func(Add);
            int res = func.Invoke(2, 3);
            Console.WriteLine(res);
            func = Sub;
            res = func.Invoke(2, 3);
            Console.WriteLine(res);
            func = Mul;
            res = func.Invoke(2, 3);
            Console.WriteLine(res);
            func = Div;
            res = func.Invoke(3, 3);
            Console.WriteLine(res);
            Console.ReadKey();
        }
        static int Add(int x,int y)
        {
            return x + y;
        }
        static int Sub(int x, int y)
        {
            return x - y;
        }
        static int Mul(int x, int y)
        {
            return x * y;
        }
        static int Div(int x, int y)
        {
            return x / y;
        }

    }
}
