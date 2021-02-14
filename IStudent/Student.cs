using System;
using System.Collections.Generic;
using System.Text;

namespace IStudent
{
    public class Student
    {
        private String Name;
        private int Grades;
        private double GetAvgGrade;

        public Student(String N, int G, double GAG)
        {
            Name = N;
            Grades = G;
            GetAvgGrade = GAG;
        }

        public String getName() { return Name; }
        public int getGrades() { return Grades; }
        public double geGetAvgGrade() { return GetAvgGrade; }

        public String toString()
        {
            String temp = Name + "  " + Grades + "  " + GetAvgGrade;
           return temp;
        }
    }
}
