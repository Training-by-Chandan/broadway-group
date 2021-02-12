using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Broadway.ConsoleApp.Subject
{
    public class Math
    {
        public void Add(decimal a, decimal b)
        {
            var result = a + b;
            Console.WriteLine($"Addition {result}");
        }
    }
}
