﻿using System;
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
    public partial class StudentName : Form
    {
        public StudentName()
        {
            InitializeComponent();
        }

        private void StudentName_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'broadwayDataSet.Student' table. You can move, or remove it, as needed.
            this.studentTableAdapter.Fill(this.broadwayDataSet.Student);

        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            
            Student s = new Student();

            s.Name = name.Text;
            s.Email = email.Text;

            var db = new BroadwayEntities();
            db.Students.Add(s);
            db.SaveChanges();

            name.Text = "";
            email.Text = "";

            dataGridView1.Refresh();


        }
    }
}
