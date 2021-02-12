using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Broadway.Project.Models.Inheritence
{
    public class Transportation
    {
        protected string str = "test string";
        protected string MoveStr(string mode)
        {
            return "Yay! I can move in "+mode;
        }
    }

    public class LandTransport : Transportation
    {
        public void Move()
        {
            Console.WriteLine(this.MoveStr("land"));
        }

        public void Move(string str)
        {
            this.str = str;
            
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
    public class SpaceTransport : Transportation
    {
        public void Move()
        {
            Console.WriteLine(this.MoveStr("space"));
        }
    }
}
