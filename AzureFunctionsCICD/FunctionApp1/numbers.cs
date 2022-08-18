using System;
using System.Collections.Generic;
using System.Text;

namespace FunctionApp1
{
    public class Numbers
    {
        private int a;
        private int b;
        private string operation;

        public Numbers(string op, int A, int B)
        {
            operation = op;
            a = A;
            b = B;
        }

        public string Operation { get => operation; set => operation = value; }
        public int B { get => b; set => b = value; }
        public int A { get => a; set => a = value; }
    }
}
