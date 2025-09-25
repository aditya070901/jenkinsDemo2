using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace jenkinsDemo2
{
    internal class Program
    {
        public int Add(int a, int b)
        {
            int c = a + b;
            return c;
        }

        public int Sub(int a, int b)
        {
            int c = a - b;
            return c;
        }

        public int Multi(int a, int b)
        {
            int c = a * b;
            return c;
        }

        public int Div(int a, int b)
        {
            int c = a / b;
            return c;
        }






        static void Main(string[] args)
        {
            Program p = new Program();
            p.Add(1, 2);
            p.Sub(3, 4);
            p.Multi(5,6);
            p.Div(5, 6);
        }
    }
}
