using System;
using System.Collections.Generic;
using System.Text;

namespace IStudent
{
    public interface IStudent
    {
        string Name { get; set; }
        string FullName
        {
            get
            {
                return "FullName";
            }
            set
            {

            }
        }
        int Grades
        {
            get
            {
                return Grades[Student];
            }
            set
            {
                Grades[Student] = value;
            }
        }
        string GetName
        {
            get
            {
                return "GetName";
            }
            set
            {

            }
        }
        string GetFullName
        {
            get
            {
                return "GetFullName";
            }
            set
            {

            }
        }
        public class Student : IStudent
        {
            public static int numberOfStudent;

            private string Name;
            public string FullName
            {
                get => Name;
                set => Name = value;
            }

            private int Grades;
            public int Grades
            {
                get => Grades;
            }
            public Student() => Grades = ++numberOfStudent;
        }
    }
}
