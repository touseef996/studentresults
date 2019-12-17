using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace StudentResults
{
    class Student
    {
        private string name;
        private char grade;

        public string getName()
        {
            return name;
        }

        public char getGrade()
        {
            return grade;
        }

        public void setName(string nameIn)
        {
            this.name = nameIn;
        }

        public void setGrade(char gradeIn)
        {
            this.grade = gradeIn;
        }

        public Student(string nameIn, char GradeIn)
        {
            this.name = nameIn;
            this.grade = GradeIn;
        }
    }
}
