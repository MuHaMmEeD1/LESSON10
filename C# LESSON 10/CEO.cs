using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace C__LESSON_10
{
    public class CEO : Person, IOrganize
    {

        public CEO(Guid id, string name, string surname, int age, string position, int salary) : base(id, name, surname, age, position, salary)
        {
        }
        public CEO()
        {
        }

        public void control()
        {
            Console.WriteLine("CONTROL");
        }

        public void organize()
        {
            Console.WriteLine("ORGANIZE");
        }

        public void makeMeeting() { Console.WriteLine("MAKE MEETIN"); }

        public void dP(double p) { Console.WriteLine(); }


    }
}