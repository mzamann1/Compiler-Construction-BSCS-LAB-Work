using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LAB2
{
    class Program
    {
        static void Main(string[] args)
        {
            string[,] arr = new string[,] { { "if", "conditional statement" }, { "switch", "conditional" }, { "prop", "Property" }, { "for", "Loop" }, { "dowhile", "Loop" }, { "while", "Loop" } ,{ "+","Operator : Addition"},{ "-","Operator : Subtraction"},{ "/","Operator : Division"}, { "*", "Operator : Multiplication" } };
            Console.WriteLine("Enter Keyword :");
            bool flag = false;
            string a = Console.ReadLine();
            for (int i =0;i<arr.Length;i++)
            {

               if (a==arr[i,0])
                {
                    flag = true;
                    Console.WriteLine(arr[i, 1]);
                    break;
                }                
               
            }
            if (!flag)
            {
                Console.WriteLine("Not Found");
            }

            Console.ReadLine();
        }
    }
}
