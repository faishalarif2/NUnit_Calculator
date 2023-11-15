using System;
using System.Collections.Generic;
using System.Text;

namespace NUnit
{

    public class Calculator
    {
        public string User(string name)
        {
            return name;
        }

        public int Addition(int a, int b)
        {
            return a + b;
        }

        public int Substraction(int a, int b)
        {
            return a - b;
        }

        public int Multiplication(int a, int b)
        {
            return a * b;
        }
    }
}
