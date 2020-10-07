using System;

namespace pr_06_var1
{
    public class Exam
    {
        public string ExamName { get; set; }
        public int ExamMark{ get; set; }
        public DateTime ExamDate{ get; set; }
        
        public Exam(string subject, int mark, DateTime examDate)
        {
            ExamName = subject;
            ExamMark = mark;
            ExamDate = examDate;
        }

        public Exam()
        {
            ExamName = "DefSubject";
            ExamMark = 5;
            ExamDate = DateTime.Now;
        }

        public override string ToString()
        {
            return ExamName + ": " + ExamMark + " " + ExamDate.ToString("dd/MM/yyyy");
        }
    }
}