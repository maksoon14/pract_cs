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
            
            int nRow, nColumn;
            Console.WriteLine("Ввдете два числа через пробел или запятую: ");
            var size = Console.ReadLine().Split(' ', ',');
            nRow = int.Parse(size[0]);
            nColumn = int.Parse(size[1]);

            var examsLinear = new Exam[nRow * nColumn];
            for(int i = 0; i < nRow * nColumn; i++)
                examsLinear[i] = new Exam();
            
            var examsDouble = new Exam[nRow, nColumn];
            for(var i = 0; i < nRow; i++)
            for(var j = 0; j < nColumn; j++)
                examsDouble[i,j] = new Exam();

            var examsJagged = new Exam[nRow][];
            for (var i = 0; i < nRow; i++)
            {
                examsJagged[i] = new Exam[nColumn];
                for (var j = 0; j < nColumn; j++)
                    examsJagged[i][j] = new Exam();
            }

            var t1 = Environment.TickCount;
            for (int i = 0; i < nRow * nColumn; i++)
                examsLinear[i].ExamMark = 5;
            var t2 = Environment.TickCount;
            var t = t2 - t1;
            Console.WriteLine("nrow: {0}, ncolumn: {1}\n", nRow, nColumn);
            Console.WriteLine("Одномерный массив: {0}", t);

            t1 = Environment.TickCount;
            for(var i = 0; i < nRow; i++)
            for(var j = 0; j < nColumn; j++)
                examsDouble[i,j].ExamMark = 5;
            t2 = Environment.TickCount;
            t = t2 - t1;
            Console.WriteLine("Двумерный прямоугольный массив: {0}", t);

            
            t1 = Environment.TickCount;
            for(var i = 0; i < nRow; i++)
            for (var j = 0; j < nColumn; j++)
                examsJagged[i][j].ExamMark = 5;
            t2 = Environment.TickCount;
            t = t2 - t1;
            Console.WriteLine("Двумерный ступенчатый массив: {0}", t);
        }
    }
}