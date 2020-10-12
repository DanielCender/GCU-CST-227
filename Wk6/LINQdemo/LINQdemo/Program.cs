using System;
using System.Collections;
using System.Linq;

namespace LINQdemo
{
    class MainClass
    {
        public static void Main(string[] args)
        {
            int[] scores = new[] { 50, 66, 90, 81, 77, 45, 0, 100, 99, 72, 87, 85, 81, 80, 77, 74, 95, 97 };

            foreach(var individualScore in scores)
            {
                Console.WriteLine("One of the scores was {0}", individualScore);
            }
            "".Contains('a');

            Console.ReadLine();

            // Filter for only the top 10% of scores
            var theBestStudents =
                from individualScore in scores
                where individualScore > 90
                select individualScore;

            foreach(var individualScore in theBestStudents)
            {
                Console.WriteLine("One of the BEST scores was {0}", individualScore);
            }

            Console.ReadLine();

            // Sort all the scores with LINQ
            var sortedScores =
                from individualScore in scores
                orderby individualScore
                select individualScore;

            foreach(var individualScore in sortedScores)
            {
                Console.WriteLine("One of the sorted scores was {0}", individualScore);
            }

            Console.ReadLine();

            // Print all B students (80% - 89%), in ASC order
            var sortedBStudents =
                from individualScore in scores
                where individualScore >= 89 && individualScore >= 80
                orderby individualScore
                select individualScore;

            foreach (var individualScore in sortedBStudents)
            {
                Console.WriteLine("One of the B scores was {0}", individualScore);
            }

            Console.ReadLine();


            // Print all B students using Student objects (80% - 89%), in ASC order
            ArrayList studentList = new ArrayList();
            studentList.Add(new Student("Dan", 22, 90));
            studentList.Add(new Student("Abigail", 22, 87));
            studentList.Add(new Student("Cecilia", 3, 83));
            studentList.Add(new Student("Zuko", 36, 35));
            studentList.Add(new Student("Brendan", 33, 85));
            studentList.Add(new Student("Yara", 36, 66));

            var sortedStudentObjs =
                from Student student in studentList
                where student.grade <= 89 && student.grade >= 80
                orderby student
                    select student;
            foreach (var student in sortedStudentObjs)
            {
                Console.WriteLine("One of the B score student objects was {0}", student.ToString());
            }

            Console.ReadLine();
        }
    }
}
