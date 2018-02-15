using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Calculator
{
    class CalcActions
    {
        public string actions(string a,string b, string c)
        {
            switch (c)
            {
                case "+":
                    a = Convert.ToString(Convert.ToDouble(a) + Convert.ToDouble(b));
                    break;

                case "-":
                    a = Convert.ToString(Convert.ToDouble(a) - Convert.ToDouble(b));
                    break;

                case "*":
                    a = Convert.ToString(Convert.ToDouble(a) * Convert.ToDouble(b));
                    break;

                case "/":
                    if (b == "0") 
                        a = "Fatal Error!!!";
                       
                   else
                        a = Convert.ToString(Convert.ToDouble(a) / Convert.ToDouble(b));

                    break;
            }
                return a;

        }
    }
}
