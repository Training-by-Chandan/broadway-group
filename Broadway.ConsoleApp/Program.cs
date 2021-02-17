using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace Broadway.ConsoleApp
{
    class Program
    {
        static void Main(string[] args)
        {
            //MathOps();
            //MathPart2();

            //InheritenceExample();
            //StaticAndNonStaticExample();

            //TypeDefs();
            //ArrayExample();
            //ListExample();

            StudentModelExample();

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

            //m.Math math = new m.Math();

            //Console.WriteLine("Addition "+math.Add(num_a, num_b));

            //Console.WriteLine($"Subtract {math.Subtract(num_a, num_b)}");

            //Console.WriteLine("Multiplication {0}", math.Multiply(num_a, num_b));

            //Console.WriteLine($"Division {math.Divide(num_a, num_b)}");

            //math.Remainder

        }

        public static void MathPart2()
        {
            Subject.Math m1 = new Subject.Math();
            m1.Add(12, 2);
        }

        static void InheritenceExample()
        {
            //Transportation t = new Transportation();
            //Transportation lt = new LandTransport();
            //LandTransport lt2 = new LandTransport();
            //t.FunctionOne();
            //lt.FunctionOne();
            //lt2.FunctionOne();
            
            //Console.WriteLine(t.ToString());
        }

        static void StaticAndNonStaticExample()
        {
            SNS s1 = new SNS();
            Console.WriteLine(s1.ToString());

           
        }

                static SNS newObj;
        static void TypeDefs()
        {
            try
            {
                object o1 = "";
                newObj.i = 1;
                SNS ObjSns = (SNS)o1; // this casting return error if the casing is not successful

                SNS ObjSns_1 = o1 as SNS; // this one will return null if casing is not successful.

                //int? o1int = o1 as int?;
                object o2 = 1;
                var a1 = 1;
                var a2 = "";
                //  a2 = new SNS();
            }
            catch (Exception e)
            {
                Console.WriteLine("Message : "+e.Message);
            }
        }


        static void ArrayExample()
        {
            int[] arr = new int[5];
            arr[0] = 5;
            arr[1] = 4;
            arr[2] = 3;
            arr[3] = 2;
            arr[4] = 1;

            Array.Resize(ref arr, 4);
            

            Console.WriteLine("");
        }

        static void ListExample()
        {
            List<string> l1 = new List<string>();
            Console.WriteLine("List Size : " + l1.Count);
            l1.Add("1");
            Console.WriteLine("List Size : " + l1.Count);
            l1.Add("2");
            Console.WriteLine("List Size : " + l1.Count);
            l1.Add("3");
            Console.WriteLine("List Size : " + l1.Count);

            l1.RemoveAt(0);
            Console.WriteLine("List Size : " + l1.Count);

            l1[0] = "4";
        }


        static void StudentModelExample()
        {
            Student s1 = new Student();
            s1.FName = "Hari";
            s1.Percentage = 90;
            Console.WriteLine(s1.Division);
            s1.Percentage = 30;
            Console.WriteLine(s1.Division);
            //s1.Division = "First";

            List<Student> students = new List<Student>();
        }
    }

    public class Student
    {
        public int Id { get; set; }
        public string FName { get; set; }
        public string LName { get; set; }

        public decimal Percentage { get; set; }

        public string Division
        {
            get
            {
                if (Percentage<0 || Percentage >100)
                {
                    return "Invalid Percentange";
                }
                else if(Percentage>80)
                {
                    return "Distinction";
                }
                else if (Percentage>60)
                {
                    return "First";
                }
                else if (Percentage > 45)
                {
                    return "Second";
                }
                else
                {
                    return "Fail";
                }
            }
        }

    }

    class SNS
    {
        public int i = 10;
        public string Name = "NewName";
       
        public void IncreaseAndDisplay()
        {
            i++;
           
            Console.WriteLine($"Value of i = {i}");
        }

        public override string ToString()
        {
            return Name + "_" + i;
        }
    }

}
