using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Broadway.ConsoleApp.Delegates
{
    public class Button
    {
        public delegate int ClickDelegate(int i, int j);

        public event ClickDelegate ClickEvent;

        public void Call()
        {
            ClickEvent?.Invoke(0, 0);
        }
    }

    class TestButton
    {
        public Button button1 = new Button();
        public void RegisterFunction()
        {
            button1.ClickEvent += Button1_ClickEvent;
            button1.ClickEvent += Button1_ClickEvent1;
        }

        private int Button1_ClickEvent1(int i, int j)
        {
            Console.WriteLine("Event 2 Executed");
            return 0;
        }

        private int Button1_ClickEvent(int i, int j)
        {
            Console.WriteLine("Event 1 Executed");
            return 0;
        }
        public void CallFunctions()
        {
            Button1_ClickEvent(0, 0);
            Button1_ClickEvent1(0, 0);

        }
    }
}
