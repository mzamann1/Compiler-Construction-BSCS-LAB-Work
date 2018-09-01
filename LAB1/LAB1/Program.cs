using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LAB1
{
    class Program
    {
        static void Main(string[] args)
        {
            //Console.WriteLine("Insert Keyword");
            Work obj = new Work();
            char i='n';
            while(i!='y')
                {
                Console.WriteLine("Insert Keyword");
                Console.WriteLine(obj.check1(Console.ReadLine()));

                Console.WriteLine(obj.check2(Console.ReadLine()));

                Console.ReadLine();
            }
            
        }
    }
}
