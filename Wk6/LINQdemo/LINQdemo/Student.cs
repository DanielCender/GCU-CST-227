using System;
namespace LINQdemo
{
    public class Student : IComparable<Student>
    {
        public string name { get; set; }
        public int age { get; set; }
        public int grade { get; set; }

        public Student()
        {
        }

        public Student(string n, int a, int g)
        {
            name = n;
            age = a;
            grade = g;
        }

        public int CompareTo(Student other)
        {
           if(grade == other.grade)
            {
                // alpha sort
                return name.CompareTo(other.name);
            }
           // else sort by grade
            return grade.CompareTo(other.grade);
        }

        public override string ToString()
        {
            return String.Format("Name: {0}, Age: {1}, Grade: {2}", name, age, grade);
        }
    }
}
