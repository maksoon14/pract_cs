using System;

namespace ConsoleApp2
{
    struct Person
    {
        public string firstname;
        public string lastname;
        public int age;

        public Person(string _firstname, string _lastname, int _age)
        {
            
            firstname = _firstname;
            lastname = _lastname;
            age = _age;
        }

        public override string ToString()
        {
            return firstname + " " + lastname + ", age " + age;
        }
    }
    class Program
    {
        static void Main(string[] args)
        {

            Person p = new Person("Tony", "Allen", 32);
            Console.WriteLine(p);
        }
    }
}