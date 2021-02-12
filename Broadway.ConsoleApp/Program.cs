using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using m = Broadway.Project.Models.Logic;
using Broadway.Project.Models;
using Broadway.VB;
using Broadway.Project.Models.Inheritence;

namespace Broadway.ConsoleApp
{
    class Program
    {
        static void Main(string[] args)
        {
            //MathOps();
            //MathPart2();

            InheritenceExample();
            Console.ReadLine();
        }

         public static void MathOps()
        {
            Console.Write("Enter the First Number: ");
            var a = Console.ReadLine();
            Console.Write("Enter the Second Number: ");
            var b = Console.ReadLine();

            var num_a = Convert.ToDecimal(a);
            var num_b = Convert.ToDecimal(b);

            m.Math math = new m.Math();

            Console.WriteLine("Addition "+math.Add(num_a, num_b));

            Console.WriteLine($"Subtract {math.Subtract(num_a, num_b)}");

            Console.WriteLine("Multiplication {0}", math.Multiply(num_a, num_b));

            Console.WriteLine($"Division {math.Divide(num_a, num_b)}");

            //math.Remainder

        }

        public static void MathPart2()
        {
            Subject.Math m1 = new Subject.Math();
            m1.Add(12, 2);
        }

        static void InheritenceExample()
        {
            Transportation t = new Transportation();
            Transportation lt = new LandTransport();
            LandTransport lt2 = new LandTransport();
            t.FunctionOne();
            lt.FunctionOne();
            lt2.FunctionOne();
        }
    }

}
