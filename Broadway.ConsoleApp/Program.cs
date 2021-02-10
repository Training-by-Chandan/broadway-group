using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Logic=Broadway.ConsoleApp.Logic;
using MathSub = Broadway.ConsoleApp.Subject.Math;
using Sub= Broadway.ConsoleApp.Subject;
using Broadway.Project.Models;
using Broadway.VB;

namespace Broadway.ConsoleApp
{
    class Program
    {
        static void Main(string[] args)
        {
            MathOps();

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

            Logic.Math math=new Logic.Math();

            Console.WriteLine("Addition "+math.Add(num_a, num_b));

            Console.WriteLine($"Subtract {math.Subtract(num_a, num_b)}");

            Console.WriteLine("Multiplication {0}", math.Multiply(num_a, num_b));

            Console.WriteLine($"Division {math.Divide(num_a, num_b)}");

        }


    }


   

    
   
}
