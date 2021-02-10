using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Broadway.ConsoleApp.Logic
{
    public class Math
    {
        public decimal Add(decimal a, decimal b)
        {
            return a + b;
        }

        public decimal Subtract(decimal a, decimal b)
        {
            return a - b;
        }

        public decimal Multiply(decimal a, decimal b)
        {
            return a * b;
        }

        public decimal Divide(decimal a, decimal b)
        {
            return a / b;
        }
    }
}
