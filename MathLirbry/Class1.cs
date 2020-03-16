using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MathLirbry
{
    public class Class1
    {
        public  decimal Add(decimal x, decimal y)
        {
            return x + y;
        }

        public decimal Less(decimal x, decimal y)
        { return x - y; }
        public decimal Multiply(decimal x , decimal y )
        { return x * y; }
        public decimal Except(decimal x, decimal y)
        { return x % y; }
    }
}
