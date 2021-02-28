using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Broadway.ConsoleApp.Interface
{
    interface IStudent
    {
        void StudentFunction();
        void Function2();
    }

    interface ISon
    {

    }
    interface IDaughter
    {

    }

    class Boy : ISon, IStudent
    {
        public void StudentFunction()
        {
            Console.WriteLine("Calling from Boy Class");
        }

        public void BoyFunction()
        {
            Console.WriteLine("Calling Boy Function from Boy Class");

        }

        public void Function2()
        {
            throw new NotImplementedException();
        }
    }

    class Girl : IDaughter, IStudent
    {
        public void StudentFunction()
        {
            Console.WriteLine("Calling from Girl Class");
        }
        public void GirlFunction()
        {
            Console.WriteLine("Calling Girl Function from Girl Class");

        }

        public void Function2()
        {
            throw new NotImplementedException();
        }
    }
}
