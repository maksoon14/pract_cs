using System;

namespace ConsoleApp2
{
    struct Person
    {
        public string firstname;
        public string lastname;
        public int age;
        public enum Genders: int { Male, Female };

        public Genders gender;
        public Person(string _firstname, string _lastname, int _age, Genders _gender)
        {
            firstname = _firstname;
            lastname = _lastname;
            age = _age;
            gender = _gender;
        }

        public override string ToString()
        {
            return firstname + " " + lastname + " ( "+ gender + " )" + ", age " + age;
        }
    }
    class Program
    {
        static void Main(string[] args)
        {

            Person p = new Person("Tony", "Allen", 32, Person.Genders.Male);
            Console.WriteLine(p);
        }
    }
}