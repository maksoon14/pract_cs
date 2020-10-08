using System;
using System.Collections.Generic;

namespace pr_06_var1
{
    class Program
    {
        static void Main(string[] args)
        {
            Student student1 = new Student();
            Console.WriteLine(student1.ToShortString());
            Console.WriteLine(student1);
            
            Console.WriteLine("Indexer test: {0}, {1}, {2}",student1[Education.Bachelor], student1[Education.Specialist], student1[Education.SecondEducation]);
            student1.Person = new Person("Makson", "Klaksonov", new DateTime(2001, 5, 15));
            student1.Education = Education.Specialist;
            student1.NumberOfGroup1 = 519;
            student1.Exam1.Add(new Exam("Math", 5, new DateTime(2019,12,15)));
            student1.Exam1.Add(new Exam("Informatics", 5, new DateTime(2019, 12, 18)));
            Console.WriteLine(student1);
            
            var AnotherExams = new List<Exam>();
            AnotherExams.Add(new Exam("History", 5, new DateTime(2020, 3, 20)));
            AnotherExams.Add(new Exam("Physics", 5, new DateTime(2020, 3, 24)));
            student1.AddExams(AnotherExams);
            Console.WriteLine(student1);
            
            
        }
    }
}