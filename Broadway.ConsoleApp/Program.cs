using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Broadway.ConsoleApp.AbstractClass;
using Broadway.ConsoleApp.Delegates;
using Broadway.ConsoleApp.Extension;
using Broadway.ConsoleApp.Interface;
using Broadway.ConsoleApp.SchoolModule;

namespace Broadway.ConsoleApp
{
    class Program
    {
        static void Main(string[] args)
        {
            string res = "N";
            do
            {
                #region Unused Functions

                //MathOps();
                //MathPart2();

                //InheritenceExample();
                //StaticAndNonStaticExample();

                //TypeDefs();
                //ArrayExample();
                //ListExample();

                //StudentModelExample();

                //UsingConvertClass();

                //ConvertClasses();

                //ExceptionExample();


                //InterfaceExample();

                //IShapeExample();

                //AbstractClassExample();

                //EnumExample();

                //FileExample();
                #endregion
                //ReferenceExample();

                DelegateEventsExample();

                Console.WriteLine("Continue (Y/N)");
                res = Console.ReadLine();
            } while (res.ToUpper() == "Y");

            Console.ReadLine(); // Using this so that we can pause the output window till enter key is pressed.
        }

        #region functions

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

        static void UsingConvertClass()
        {
            //we use Convert class to convert from one type to another type. We can use only those functions which are defined in the Convert Class

            int i = 10;
            var j = Convert.ToChar(i);
            var k = Convert.ToString(i);
            var l = Convert.ToBoolean(i);



            Console.WriteLine("Char => " + j);
            Console.WriteLine("String => " + k);
            Console.WriteLine("Boolean => " + l);

        }

        static void UsingNormalCasting()
        {
            //we can convert from any one type to another 
            int i = 10;
            var j = (char)i;
            var k = i.ToString();
            

            Console.WriteLine("Char => " + j);
            Console.WriteLine("String => " + k);
            

        }


        static void ConvertClasses()
        {
            Human h = new Human();
            Teacher t = new Teacher();
            Student s = new Student();
            
            
            var h_t = t as Human;
            var h_s = s as Human;

            var h_t_1 = (Human)t;
            var h_s_1 = (Human)s;

            h_t = h_s;
        }

        static void ExceptionExample()
        {
            try
            {
                Marks m1 = new Marks();
                m1.Name = "Anchal";
                m1.Computer = 101;
                m1.Math = 12;

                m1.isValid();

             
            }
            catch(ComputerMarksNotValidException e)
            {
                Console.WriteLine("Wrong computer marks");
            }
            catch(MathMarksNotValidException e)
            {
                Console.WriteLine("Wrong math marks");
            }
            catch (Exception e)
            {
                Console.WriteLine("Something wrong happened");
            }
            finally
            {
                Console.WriteLine("Everything is Sorted and Handled");
            }
        }

        static void InterfaceExample()
        {
            IStudent s1;
            Boy b1 = new Boy();
            b1.StudentFunction();
            
            s1 = b1;
            
            s1.StudentFunction();
           
            Girl g1 = new Girl();
            g1.StudentFunction();
            s1 = g1;
            s1.StudentFunction();


            IStudent[] listofStudent = new IStudent[10];
            listofStudent[0] = b1;
            listofStudent[1] = g1;

        }

            static IShape s1;
        static void IShapeExample()
        {
            
            Console.WriteLine("Press\n1 for Rectangle\n2 for Triangle\n3 for Circle");
            var item = Convert.ToInt32(Console.ReadLine());
            switch (item)
            {
                case 1:
                    s1 = new Rectangle();
                    break;
                case 2:
                    s1 = new Triangle();
                    break;
                case 3:
                    s1 = new Circle();
                    break;
                default:
                    break;
            }

            s1.GetInput();
            s1.Area();
            s1.Perimeter();

        }

        static void AbstractClassExample()
        {
            Pig myPig = new Pig();  // Create a Pig object
            myPig.animalSound();
            myPig.sleep();
            var test=myPig.StrReadonly ;
            var t=Pig.StrConstant;

            Pig newPig = new Pig("I am from Program.cs file");

        }

        static void EnumExample()
        {
            Console.WriteLine("Enter Number");
            var num = Convert.ToInt32(Console.ReadLine());

            var days = (Days)num;

            
            switch (days)
            {
                case Days.Sunday:
                case Days.Saturday:
                    Console.WriteLine("Its Weekend! Enjoy");
                    break;
                case Days.Monday:
                case Days.Tuesday:
                case Days.Wednesday:
                case Days.Thursday:
                case Days.Friday:
                    Console.WriteLine("Its Weekdays, Lets get working");
                    break;

              
            }
        }


            static FileStream fs;
        static void FileExample()
        {
            Console.WriteLine("Enter the string that you want to write in file");
            var str = Console.ReadLine();
            str += "\n";
            var bytes = Encoding.ASCII.GetBytes(str);
            fs = File.Open("nbc.txt", FileMode.Append);
            
            fs.Write(bytes, 0, bytes.Length);
            fs.Close();
        }

        #endregion

        static void ReferenceExample()
        {
            int j = 5;
            Add(j);
            Console.WriteLine(j);
            AddRef(ref j);
            Console.WriteLine(j);

            int outval = 0;
            AddOut(j, out outval);
            Console.WriteLine("j=>"+j);
            Console.WriteLine("Out => "+outval);

        }

        static void Add(int i)
        {
            i = i + 1;
        }

        static void AddRef(ref int i) 
        { 
            i = i + 1; 
        }

        static void AddOut (int j, out int i)
        {
            i = j + 1;
        }


        static void DelegateEventsExample()
        {
            TestButton tb = new TestButton();
            tb.button1.ClickEvent += Button1_ClickEvent;
            tb.RegisterFunction();
            tb.RegisterFunction();
            tb.button1.Call();
        }

        private static int Button1_ClickEvent(int i, int j)
        {
            Console.WriteLine("Calling from program.cs");
            return 0;
        }
    }

    public class Human
    {

    }

    public class Teacher : Human
    {

    }

    public class Student : Human
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

    public enum Days
    {
        Sunday=0, 
        Monday=1,
        Tuesday=2, 
        Wednesday=3, 
        Thursday=4, 
        Friday=5, 
        Saturday=6
    }

}
