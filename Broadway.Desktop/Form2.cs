using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Broadway.Desktop
{
    public partial class Form2 : Form
    {
        private double Number1 = 0;
        private double Number2 = 0;
        private double Result = 0;
        private string operation = "";

        public Form2()
        {
            InitializeComponent();
        }

        private void Form2_Load(object sender, EventArgs e)
        {
            
        }


        private void btnNumber_Click(object sender, EventArgs e)
        {
            Button b = (Button)sender;
            if (textBox1.Text.Contains(".") && b.Text==".")
            {

            }
            else
            {
                textBox1.Text += b.Text;

            }
           
        }

        private void btnOperation_Click(object sender, EventArgs e)
        {
            Number1 = Convert.ToDouble(textBox1.Text);
            textBox1.Text = "";

            Button b = (Button)sender;
            operation = b.Text;

           

        }

        private void btnequals_Click(object sender, EventArgs e)
        {
            Number2 = Convert.ToDouble(textBox1.Text);
            if (operation=="+")
            {
                Result = Number1 + Number2;
            }
            else if (operation == "-")
            {
                Result = Number1 - Number2;
            }
            else if (operation == "x")
            {
                Result= Number1 * Number2;
            }
            else if (operation == "/")
            {
                Result= Number1 / Number2;
            }

            textBox1.Text = Result.ToString();


            richTextBox1.Text += Number1.ToString() + "\n";
            richTextBox1.Text += Number2.ToString()+" "+operation+"\n";
            richTextBox1.Text += "_________________" + "\n";
            richTextBox1.Text += Result.ToString()+"\n\n";

        }

        private void btnclr_Click(object sender, EventArgs e)
        {
            Number1 = 0;
            Number2 = 0;
            Result = 0;
            operation = "";
            textBox1.Text = "";
        }

        private void testToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void helpToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form1 f1 = new Form1();
            f1.Show();
        }

        private void Form2_KeyPress(object sender, KeyPressEventArgs e)
        {
            switch (e.KeyChar)
            {
                case '1':
                case '2':
                case '3':
                case '4':
                case '5':
                case '6':
                case '7':
                case '8':
                case '9':
                case '0':
                case '.':
                    if (textBox1.Text.Contains(".") && e.KeyChar == '.')
                    {

                    }
                    else
                    {
                        textBox1.Text += e.KeyChar;

                    }
                    break;

                case '+':
                case '-':
                case '*':
                case '/':
                    Number1 = Convert.ToDouble(textBox1.Text);
                    textBox1.Text = "";

                    
                    operation = e.KeyChar.ToString();
                    break;
                case '=':
                    btnequals_Click(null, null);
                    break;
                default:
                    break;
            }
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            
        }
    }

    
}
