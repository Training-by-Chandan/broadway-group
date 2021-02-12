using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Broadway.Project.Models
{
    public class Class1
    {
        protected internal string str = "";
    }

    class Class2 : Class1
    {
        public Class2()
        {
            var s = str;
        }
    }
}
