using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CalcUlator
{
    class operations
    {

        public double numOne = 0, numTwo = 0, ans = 0;
        public string Opr = "none";

        public void getValues(double n1, double n2, string opr)
        {
            numOne = n1;
            numTwo = n2;
            Opr = opr;
        }

        public void calculateVal()
        {
            if(Opr == "mul")
            {
                ans = numOne * numTwo;
            }
            else if (Opr == "add")
            {
                ans = numOne + numTwo;
            }
            else if(Opr == "div")
            {
                ans = numOne / numTwo;
            }
            else if (Opr == "min")
            {
                ans = numOne - numTwo;
            }
            else if (Opr == "mod")
            {
                ans = numOne % numTwo;
            }
            else
            {

            }
        }

        public double returnAns()
        {
            return ans;
        }


    }

}
