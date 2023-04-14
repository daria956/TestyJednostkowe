using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TestyJednostkowe
{

    public class Calculator
    {
        public int Multiplication(int a, int b)
        {
            return a * b;
        }

        public int Division(int a, int b)
        {
            return a / b;
        }
        public int MultiplicationAndDivion(int a, int b, int c )
        {
            return (a * b) / c;

        }
    }


}
