using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MathLirbry;

namespace MathLirbry
{
    public class Class1
    {
        public decimal Add(decimal x, decimal y)
        {
            return x + y;
        }

        public decimal Less(decimal x, decimal y)
        {
            return x - y;
        }
        public decimal Multiply(decimal x, decimal y)
        {
            return x * y;
        }
        public decimal Except(decimal x, decimal y)
        {
            return x % y;
        }
        public decimal Persent(decimal x, decimal y)
        {
            return x % 100;
        }
        public int Power(int x, int y)
        {
            return x ^ y;
        }
        public Double Root(int x )
        { 
            return  Math.Sqrt(x);
        }
        public Double Log(int x)
        {
            return Math.Log(x);
        }
        public Double Natural(int x)
        {
           return Math.Log(x, Math.E);
        }
    }
}
