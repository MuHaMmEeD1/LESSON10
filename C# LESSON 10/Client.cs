using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace C__LESSON_10
{
    public class Client
    {


        public Guid Id { get; set; }
        public string Name { get; set; }
        public string Surname { get; set; }
        public int age { get; set; }
        public string live_address { get; set; }
        public string work_address { get; set; }
        public int salary { get; set; }


        public Client(Guid id, string name, string surname, int age, string live_address, string work_address, int salary)
        {
            Id = id;
            Name = name;
            Surname = surname;
            this.age = age;
            this.live_address = live_address;
            this.work_address = work_address;
            this.salary = salary;
        }


        public Client()
        {

        }

        public void show()
        {
            Console.WriteLine($"Ii {Id}");
            Console.WriteLine($"Name {Name}");
            Console.WriteLine($"Surname {Surname}");
            Console.WriteLine($"Age {age}");
            Console.WriteLine($"live_address {live_address}");
            Console.WriteLine($"work_address {work_address}");
            Console.WriteLine($"salary {salary}\n");
        }


    }
}