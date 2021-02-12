using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Broadway.Project.Models.Inheritence
{
    public class Transportation
    {
        public Transportation()
        {

        }
        public Transportation(string str)
        {
            this.str = str;
        }

        public Transportation(string str, int i)
        {

        }
        public Transportation(int i, string str)
        {

        }
        protected string str = "test string";
        protected string MoveStr(string mode)
        {
            return "Yay! I can move in "+mode;
        }

        public virtual void FunctionOne()
        {
            Console.WriteLine("I am from base class Transportation");
        }
    }

    public class LandTransport : Transportation
    {
        public LandTransport() : base()
        {

        }

        public LandTransport(string str) : base(str)
        {

        }

        public void Move()
        {
            Console.WriteLine(this.MoveStr("land"));
        }

        public void Move(string str)
        {
            this.str = str;
            
        }

        public override void FunctionOne()
        {
            Console.WriteLine("I am from child class LandTransport");
        }
    }

    public class AirTransport : Transportation
    {
        public void Move()
        {
            Console.WriteLine(this.MoveStr("air"));
        }
    }

    public class WaterTransport : Transportation
    {
        public void Move()
        {
            Console.WriteLine(this.MoveStr("water"));
        }
    }
    public class SpaceTransport : AirTransport
    {
        public void Move()
        {
            Console.WriteLine(this.MoveStr("space"));
        }
    }


}
