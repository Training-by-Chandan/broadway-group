using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Broadway.ConsoleApp.SchoolModule
{
    
    public class Marks
    {
        public string Name { get; set; }
        
        private double computer;
        public double Computer { 
            get 
            { 
                return computer; 
            } 
            set 
            { 
                computer = value; 
            } 
        }

        private double science;
        public double Science
        {
            get
            {
                return science;
            }
            set
            {
                science = value;
            }
        }

        private double math;
        public double Math
        {
            get
            {
                return math;
            }
            set
            {
                math = value;
            }
        }


        public void isValid()
        {
            if (this.computer<0 || this.computer>100)
            {
                var baseException = new Exception("Base Exception");
                throw new ComputerMarksNotValidException("",baseException);
            }

            if (this.math < 0 || this.math > 100)
            {
                throw new MathMarksNotValidException();
            }

            Console.WriteLine("Everything is OK");
        }
    }


    //public class ComputerMarksNotValidException : Exception
    //{

    //}
    //public class MathMarksNotValidException : Exception
    //{

    //}

    [Serializable]
    public class ComputerMarksNotValidException : Exception
    {
        public ComputerMarksNotValidException() { }
        public ComputerMarksNotValidException(string message) : base(message) { }
        public ComputerMarksNotValidException(string message, Exception inner) : base(message, inner) { }
        protected ComputerMarksNotValidException(
          System.Runtime.Serialization.SerializationInfo info,
          System.Runtime.Serialization.StreamingContext context) : base(info, context) { }
    }



    [Serializable]
    public class MathMarksNotValidException : Exception
    {
        public MathMarksNotValidException() { }
        public MathMarksNotValidException(string message) : base(message) { }
        public MathMarksNotValidException(string message, Exception inner) : base(message, inner) { }
        protected MathMarksNotValidException(
          System.Runtime.Serialization.SerializationInfo info,
          System.Runtime.Serialization.StreamingContext context) : base(info, context) { }
    }

    [Serializable]
    public class TestException : Exception
    {
        public TestException() { }
        public TestException(string message) : base(message) { }
        public TestException(string message, Exception inner) : base(message, inner) { }
        protected TestException(
          System.Runtime.Serialization.SerializationInfo info,
          System.Runtime.Serialization.StreamingContext context) : base(info, context) { }
    }

}
