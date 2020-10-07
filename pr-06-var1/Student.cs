using System.Collections.Generic;
using System.Linq;
namespace pr_06_var1
{
    public class Student
    {
        private Person person1;
        private Education education1;
        private int NumberOfGroup;
        private List<Exam> exam1;

        public Student(Person _person1, Education _education1, int _NumberOfGroup)
        {
            person1 = _person1;
            education1 = _education1;
            NumberOfGroup = _NumberOfGroup;
            exam1 = new List<Exam>();
        }

        public Student()
        {
            person1 = new Person();
            education1 = Education.Bachelor;
            NumberOfGroup = 0;
            exam1 = new List<Exam>();
        }
        public Person Person
        {
            get => person1;
            set => person1 = value;
        }

        public Education Education
        {
            get => education1;
            set => education1 = value;
        }
        
        public int NumberOfGroup1
        {
            get => NumberOfGroup;
            set => NumberOfGroup = value;
        }

        public List<Exam> Exam1
        {
            get => exam1;
            set => exam1 = value;
        }
        
        public double AverageScore
        {
            get
            {
                double x = 0;
                if (exam1.Count > 0)
                {
                    foreach (var iExam in exam1)
                        x += iExam.ExamMark;
                    x /= exam1.Count;
                }
                return x;
            }
        }
        
        public bool this[Education _education1]
        {
            get
            {
                return education1 == _education1 ? true : false;
            }
        }
        
        public void AddExams(List<Exam> exams)
        {
            for (var i = 0; i < exams.Count; i++)
            {
                Exam1.Add(exams[i]);
            }
        }

        public override string ToString()
        {
            var s = Person + " " + Education + " " + NumberOfGroup1;
            foreach (var iExam in Exam1)
            {
                s += "\n" + iExam;
            }
            return s;
        }
        
        public string ToShortString()
        {
            return Person + " " + Education + " " + NumberOfGroup1 + " " + AverageScore;
        }
    }
}