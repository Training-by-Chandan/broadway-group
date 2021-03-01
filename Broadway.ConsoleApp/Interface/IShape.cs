using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Broadway.ConsoleApp.Interface
{
    public interface IShape
    {
        void GetInput();
        void Area();
        void Perimeter();
    }

    public class Rectangle : IShape
    {
        public double Length { get; set; }
        public double Breadth { get; set; }
        public void Area()
        {
            Console.WriteLine($"Area = {this.Length * this.Breadth}");
        }

        public void GetInput()
        {
            Console.WriteLine("Enter Length");
            var length = Console.ReadLine();
            Console.WriteLine("Enter Breadth");
            var breadth = Console.ReadLine();


            this.Length = Convert.ToDouble(length);
            this.Breadth = Convert.ToDouble(breadth);
        }

        public void Perimeter()
        {
            Console.WriteLine($"Perimeter = {2*(this.Length + this.Breadth)}");
        }
    }

    public class Triangle : IShape // Equilateral Triangle
    {
        public double Length { get; set; }
      
        public void Area()
        {
            Console.WriteLine($"Area = {(Math.Sqrt(3)/4)* Math.Pow(this.Length,2)}");

        }

        public void GetInput()
        {
            Console.WriteLine("Enter Length");
            var length = Console.ReadLine();

            this.Length = Convert.ToDouble(length);
        }

        public void Perimeter()
        {
            Console.WriteLine($"Perimeter = {3 * this.Length}");
        }
    }

    public class Circle : IShape
    {
        public void Area()
        {
            throw new NotImplementedException();
        }

        public void GetInput()
        {
            throw new NotImplementedException();
        }

        public void Perimeter()
        {
            throw new NotImplementedException();
        }
    }
}
