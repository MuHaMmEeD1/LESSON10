using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace C__LESSON_10
{
    public class Manager : Person, IOrganize
    {
        public Manager(Guid id, string name, string surname, int age, string position, int salary) : base(id, name, surname, age, position, salary)
        {
        }

        public void organize()
        {
            Console.WriteLine("ORGANIZE");
        }

        public void CS() { Console.WriteLine($"Salery: {Salary * 12}"); }

    }
}