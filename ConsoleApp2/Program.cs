using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp2
{
    internal class Program
    {
        public void display()
        {
            Console.WriteLine("Hello Jenkins");
        }
        static void Main(string[] args)
        {
            Program p = new Program()
            p.display();
            Console.ReadLine();
        }
    }
}
