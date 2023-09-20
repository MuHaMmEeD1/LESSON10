using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace C__LESSON_10
{
    public class Person : IPerson
    {

        public Guid Id { get; set; }
        public string Name { get; set; }
        public string Surname { get; set; }
        public int Age { get; set; }
        public string Position { get; set; }
        public int Salary { get; set; }


        public Person(Guid id, string name, string surname, int age, string position, int salary)
        {
            Id = id;
            Name = name;
            Surname = surname;
            Age = age;
            Position = position;
            Salary = salary;
        }


        public Person() { }


    }







}