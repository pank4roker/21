using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _21_1_
{
    class Program
    {
        delegate void Show();
        static void Main(string[] args)
        {
            Show show;
            if(DateTime.Now.Hour < 12)
            {
                show = GoodMorning;
            }
            else
            {
                show = GoodEvening;
            }
            show.Invoke();
            Console.ReadLine();
        }

        private static void GoodMorning()
        {
            Console.WriteLine("Доброу утро!");
        }
        private static void GoodEvening()
        {
            Console.WriteLine("Добрый вечер!");
        }
    }
}
