using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab17
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Account<int> acc1 = new Account<int>();
            //acc1.SetInfo();
            //Console.WriteLine(acc1.ShowInfo());

            Account<string> acc2 = new Account<string>();
            acc2.SetInfo();
            Console.WriteLine(acc2.ShowInfo());
            Console.ReadKey();
        }
    }
}
