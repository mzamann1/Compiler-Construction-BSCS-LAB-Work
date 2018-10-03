using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LexiFinal
{
    class Program
    {
        static void Main(string[] args)
        {
            int id_cntr = 0;

            string input = Console.ReadLine();
            string[] arr = new string[] { };
            arr = input.Split(' ');

            bool flag1 , flag2 , flag3 , flag4, flag5 ;
            Work w = new Work();
            for (int i = 0; i < arr.Length; i++)
            {
                flag1 = false; flag2 = false; flag3 = false; flag4 = false; flag5 = false;

                var data = w.isKeyword(arr[i]);
                if (data.Item1)
                {
                    flag1 = true;
                    Console.WriteLine(data.Item2);
                    
                }
               data = w.isOperator(arr[i]);
               if (data.Item1)
                {
                   flag2 = true;
                    Console.WriteLine(data.Item2);
                    
                }
                data = w.isPunc(arr[i]);

                if (data.Item1)
                {
                    flag3 = true;
                    Console.WriteLine(data.Item2);
                    
                }
                data = w.isValue(arr[i]);
                if (data.Item1)
                {
                    flag4 = true;
                    Console.WriteLine(data.Item2);
                }
                data = w.DataType_keyword(arr[i]);
                if (data.Item1)
                {
                    flag5 = true;
                    Console.WriteLine(data.Item2);
                }
                if ((flag1==false) && (flag2==false) && (flag3==false) && (flag4==false) && (flag5==false))
                {
                    id_cntr++;
                    Console.WriteLine("< id {0} , {1} >", id_cntr, arr[i]);
                }
                data = null;

            }
           
              //  Console.WriteLine("string");


            Console.ReadLine();
        }
    }
}
