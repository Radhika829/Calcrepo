using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CalcExample
{
    public class Clac
    {
        public void Add(double n1, double n2)
        {
            Console.WriteLine( "result after addition:\t" +(n1+n2));
        }
        public void Sub(double n1, double n2)
        {
            Console.WriteLine("result after subtraction:\t" + (n1 - n2));
        }
        public void Multi(double n1, double n2)
        {
            Console.WriteLine("result after multiplication:\t" + (n1 * n2));
        }
        public void div(double n1, double n2)
        {
            Console.WriteLine("result after division:\t" + (n1 / n2));
        }
    }
}
