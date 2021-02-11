using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using anything = Broadway.Project.Models.Logic;

namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {
            anything.Math m = new anything.Math();
            
            Console.WriteLine("Running from the second application");
            Console.ReadLine();
        }
    }
}
