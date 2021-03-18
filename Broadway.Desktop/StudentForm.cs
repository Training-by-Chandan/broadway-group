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
    public partial class StudentForm : Form
    {
        private AdmissionService admissionService = new AdmissionService();
        public StudentForm()
        {
            InitializeComponent();
            dataGridView1.SelectionChanged += DataGridView1_SelectionChanged;
        }

        private void DataGridView1_SelectionChanged(object sender, EventArgs e)
        {
            if (dataGridView1.Rows.Count>0 && dataGridView1.SelectedRows.Count>0)
            {


            var selectedRow = dataGridView1.SelectedRows[0];
            textBox1.Text = selectedRow.Cells["Name"].Value?.ToString();
            textBox2.Text = selectedRow.Cells["Email"].Value?.ToString();

                label3.Text = selectedRow.Cells["Id"].Value?.ToString();
            }
        }

        private void StudentForm_Load_1(object sender, EventArgs e)
        {
            Refresh();
        }

        private void Refresh()
        {
            var students = admissionService.GetStudents();
            dataGridView1.DataSource = students;
            dataGridView1.Refresh();
        }

        private void dataGridView1_MouseDoubleClick(object sender, MouseEventArgs e)
        {
           
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Student s1 = new Student();
            
            s1.Id = string.IsNullOrWhiteSpace(label3.Text)?0: Convert.ToInt32(label3.Text);
            s1.Name = textBox1.Text;
            s1.Email = textBox2.Text;

            if (string.IsNullOrWhiteSpace(label3.Text))
            {
                admissionService.StudentCreate(s1);
            }
            else
            {
                admissionService.StudentEdit(s1);
            }

            Refresh();

            label3.Text = "";
            textBox1.Text = "";
            textBox2.Text = "";
        }
    }
}
