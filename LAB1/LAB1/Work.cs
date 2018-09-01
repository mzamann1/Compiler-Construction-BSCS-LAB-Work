using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Text.RegularExpressions;


namespace LAB1
{
    class Work
    {
        public bool IsDigit(string inp)
        {
            foreach (char s in inp)
            {
                if (s < '0' || s > '9')
                 return false; 
                else
                 return true;
            } 
            
            return true;
        }

        public string check1(string input)
        {

            if (input.StartsWith("int") && input.Length==3)
            {
                
                return "Integer";
            }
        
            else if (input.StartsWith("float") && input.Length==5)
            {
                return "Float";
            }
            else if (input.StartsWith("double") && input.Length == 6)
            {
                return "Double";
            }
            else if (input.Length == 1)
            {
                return "character";
            }
            return "string";


        }
        public string check2(string inp)
        {
            if (this.IsDigit(inp) && inp.Contains('.'))
            {
                int c = 0;
                for (int i = 0; i < inp.Length; i++)
                {
                    if (inp[i] == '.')
                    {
                        c++;
                    }
                }
                if (c == 1)
                {
                    return "NUmeric : Float";
                }
                else
                {
                    return "String";
                }
            }
            else if (this.IsDigit(inp) == true && !inp.Contains('.'))
                return "Numeric : Integer";

            else if (!this.IsDigit(inp) && inp.Length == 1)
                return "character";


            else
                return "String outside";
        }
       
    }
}
