using System;

namespace pr_06_var1
{
    public class Person
    {
        private string firstname;
        private string lastname;
        private DateTime date;

        public Person(string _firstname, string _lastname, DateTime _date)
        {
            firstname = _firstname;
            lastname = _lastname;
            date = _date;
        }

        public Person()
        {
            firstname = "Ivan";
            lastname = "Nozdrin";
            date = new DateTime(2001, 9, 21);
        }

        public string Firstname
        {
            get
            {
                return firstname;
            }
            set
            {
                firstname = value;
            }
        }

        public string Lastname
        {
            get
            {
                return lastname;
            }
            set
            {
                lastname = value;
            }
        }

        public DateTime Date
        {
            get
            {
                return date;
            }
            set
            {
                date = value;
            }
        }

        public int DateYear
        {
            get
            {
                return date.Year;
            }
            set
            {
                DateTime _date = new DateTime(value, date.Month, date.Day );
                date = _date;
            }
        }

        public override string ToString()
        {
            return firstname.ToString() + " " + lastname.ToString() + " " + date.ToString("dd/MM/yyyy");
        }

        public string ToShortString()
        {
            return firstname.ToString() + " " + lastname.ToString();
        }
    }
}