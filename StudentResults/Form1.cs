using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace StudentResults
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        Course aCourse;

        private void btnAdd_Click(object sender, EventArgs e)
        {
            string name = txtName.Text;
            char grade = Convert.ToChar(txtGrade.Text);

            aCourse.addStudentToCourse(name,grade);

            refreshListBox();
        }

        public void refreshListBox()
        {
            lstNames.Items.Clear();
            lstGrades.Items.Clear();
            foreach (KeyValuePair<string,char> stud in aCourse.getStudents())
            {              
                lstNames.Items.Add(stud.Key);
                lstGrades.Items.Add(stud.Value);
            }
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            aCourse = new Course();
        }
    }
}
