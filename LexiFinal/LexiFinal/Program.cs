using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Text.RegularExpressions;

namespace LexiFinal
{
    class Program
    {
        static void Main(string[] args)
        {
            int id_cntr = 0;
            List<KeyValuePair<string, string>> List = new List<KeyValuePair<string, string>>();
            int a = 0;
            while (a < 5)
            {
                string input = Console.ReadLine();

                if (input == "")
                {
                    Environment.Exit(0);
                }

                string[] arr = new string[] { };
                arr = input.Split(' ');

                bool flag1, flag2, flag3, flag4, flag5;
                Work w = new Work();


                for (int i = 0; i < arr.Length; i++)
                {
                    flag1 = false; flag2 = false; flag3 = false; flag4 = false; flag5 = false;

                    var data = w.isKeyword(arr[i]);
                    if (data.Item1)
                    {
                        flag1 = true;
                        Console.WriteLine(data.Item2);

                        List.Add(Break(data.Item2));

                    }
                    data = w.isOperator(arr[i]);
                    if (data.Item1)
                    {
                        flag2 = true;
                        Console.WriteLine(data.Item2);
                        List.Add(Break(data.Item2));

                    }
                    data = w.isPunc(arr[i]);

                    if (data.Item1)
                    {
                        flag3 = true;
                        Console.WriteLine(data.Item2);
                        List.Add(Break(data.Item2));
                        // newarr[i] = data.Item2;

                    }
                    data = w.isValue(arr[i]);
                    if (data.Item1)
                    {
                        flag4 = true;
                        Console.WriteLine(data.Item2);
                        List.Add(Break(data.Item2));
                        //newarr[i] = data.Item2;
                    }
                    data = w.DataType_keyword(arr[i]);
                    if (data.Item1)
                    {
                        flag5 = true;
                        Console.WriteLine(data.Item2);
                        List.Add(Break(data.Item2));
                        //newarr[i] = data.Item2;
                    }
                    if ((flag1 == false) && (flag2 == false) && (flag3 == false) && (flag4 == false) && (flag5 == false))
                    {
                        id_cntr++;
                        Console.WriteLine("id {0},{1}", id_cntr, arr[i]);
                        string last = string.Format("id {0},{1}", id_cntr, arr[i]);
                        List.Add(Break(last));
                        // newarr[i] = string.Format("< id {0},{1} >", id_cntr, arr[i]);
                    }

                    data = null;

                }





                int k = 0;




                if (List[0].Key == "DataType")
                {
                    if (k <= List.Count - 1)
                    {
                        k++;
                        if (List[k].Key.Contains("id"))
                        {


                            //   newStr = newStr.Substring(newStr.LastIndexOf(',') + 1);

                            if (Regex.IsMatch(List[k].Value, @"[0-9][A-Za-z]"))
                            {

                                Console.WriteLine("after datatype error");

                            }
                            else
                            {

                                if (k <= List.Count - 1)
                                {
                                    k++;

                                    if (List[k].Key.Contains("Operator") && ((List[k].Value == ",") || List[k].Value == "="))
                                    {
                                        if (List[k].Value == ",")
                                        {
                                            if (List[k + 1].Value == "=")
                                            {
                                                Console.WriteLine("Error after comma");
                                            }
                                            if (List[k+1].Key.Contains("id"))
                                            {

                                            }
                                        }


                                        if (List[k].Value == "=")
                                        {
                                            if (k < List.Count - 1)
                                            {
                                                k++;
                                                if (List[k].Value.Contains("Value"))
                                                {
                                                    Console.WriteLine("Error at assignig value");
                                                }

                                            }
                                        }


                                    }
                                    else
                                    {
                                        Console.WriteLine($"No Operator Found after at token {k}");
                                    }
                                }
                            }
                        }
                    }

                    else
                    {
                        Console.WriteLine("In - Error");
                    }
                }
                else
                {
                    Console.WriteLine("No datatype  at start");
                }

            }
            //  Console.WriteLine("string");


            Console.ReadLine();
        }
        public static KeyValuePair<string,string>  Break(string input)
        {
            
            string key =input.Substring(0, input.LastIndexOf(','));
            string pair = input.Substring(input.IndexOf(',')+1);

            return new KeyValuePair<string,string>(key,pair);
        }
    }
}
