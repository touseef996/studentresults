using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.IO;
using System.Windows.Forms;

namespace StudentResults
{
    class Course
    {
        private int numberOfStudents;
        private Dictionary<string, char> students;

        // Constructor for Course - creates a new empty dictionary and sets number of students = 0
        public Course()
        {
            this.numberOfStudents = 0;
            this.students = new Dictionary<string, char>();
        }

        public Dictionary<string, char> getStudents()
        {
            return students;
        }

        // Adds 1 to number of students
        public void increaseStudents()
        {
            this.numberOfStudents = this.numberOfStudents + 1;
        }

        public int getNumOfStudent()
        {
            return numberOfStudents;
        }

        // Pass in the student ID, this will return the students Grade
        public char getGrade(string studentIn)
        {
            if (this.students.ContainsKey(studentIn))
            {
                char grade;
                students.TryGetValue(studentIn, out grade);
                return grade;
            }
            return ' ';
        }

        public void addStudentToCourse(string studentIn, char gradeIn)
        {
            if (!this.students.ContainsKey(studentIn))
            {
                students.Add(studentIn, gradeIn);
                increaseStudents();
            }
            else
            {
                MessageBox.Show("Cannot add Student");
            }
        }




    }
}
