using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LexiFinal
{
    class Work
    {
        int value_cntr=0, op_cntr=0, punc_cntr=0;
        public string[] keywords_list = new string[] { "default", "is", "new", "break" };
        public string[,] op_list = new string[,] { { "+", "Operator : Add" }, { "-", "Operator : Minus" }, {"=","assignment Operator" }, { "/", "Operator : Division" }, { "%", "Operator : Modulus" } };
        public string[,] puncOp_list = new string[,] { { "(", "Open Small Parenthesis" }, { ")", "Closed Small Parenthesis" }, { "{", "Open Curly Braces" }, { "}", "Closed Curly Braces" }, { ";", "Delimeter" }, { ",", "comma" } };

        public Tuple<bool,string> isKeyword(string input)
        {
           
            bool flag = false;
          //  int pos = 0;
            for (int i = 0; i < keywords_list.Length; i++)
            {
                if (input == keywords_list[i])
                {
                    flag = true;
                  
                    break;
                }
               
            }

            return flag ? Tuple.Create(true, string.Format(" keyword  ,{0} ",input)) : Tuple.Create(false, "");


        }

        //public string isID(
        public Tuple<bool,string> isOperator(string input)
        {
           
            bool flag = false;
            int pos = 0;
            for (int i = 0; i < op_list.GetLength(0); i++)
            {
                if (input == op_list[i, 0])
                {
                    flag = true;
                    op_cntr++;
                    pos = i;
                    break;
                }


            }

            return flag ? Tuple.Create(true,string.Format("{0} {1},{2}",op_list[pos,1], op_cntr, input)) :Tuple.Create(false,"");

        }
        public Tuple<bool,string> isPunc(string input)
        {
            
            bool flag = false;
            int pos = 0;
            for (int i = 0; i < puncOp_list.GetLength(0); i++)
            {
                if (input == puncOp_list[i, 0])
                {
                    flag = true;
                    punc_cntr++;
                    pos = i;
                    break;
                }

            }

            return flag ? Tuple.Create(true,string.Format(" Punc. Operator {0}  {1},{2}",puncOp_list[pos,1], punc_cntr, input)): Tuple.Create(false,"");

        }

        public Tuple<bool,string> isValue(string input)
        {
            string[] arr = new string[] { };

            if (input.Contains('.'))
            {
                int c = 0;
                for (int i = 0; i < input.Length; i++)
                {
                    if (input[i]=='.')
                    {
                        c++;
                    }
                }
                if (c==1)
                {
                    arr = input.Split('.');
                    return isDigit(arr[0]) && isDigit(arr[1]) ?Tuple.Create(true,string.Format(" Value {0},{1}", value_cntr++, input)) : Tuple.Create(false,"");

                }
                

            }
            
            return isDigit(input) ? Tuple.Create(true,string.Format(" Value{0},{1}", value_cntr++, input)) :Tuple.Create(false,"");

        }

        public Tuple<bool,string> DataType_keyword(string input)
        {
            if (((input.Length==5) && (input.StartsWith("float"))) || ((input.Length==6) && ((input.StartsWith("double")) || input.StartsWith("string"))) || ((input.Length == 3) && (input.StartsWith("int"))))
            {
                return Tuple.Create(true, string.Format("DataType,{0}", input));
            }
            return Tuple.Create(false, "");

        }
        public bool isDigit(string input)
        {
            return input.All(char.IsDigit);
        }
    }
}