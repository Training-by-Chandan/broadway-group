using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Broadway.ConsoleApp.Extension
{
    public static class StringExtension
    {
        public static int ToInt(this string i)
        {
            return Convert.ToInt32(i);
        }
    }
}
