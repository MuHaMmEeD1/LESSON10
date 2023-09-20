using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace C__LESSON_10
{
    public class WORKER : Person
    {

        public DateTime startTime { get; set; }
        public DateTime endTime { get; set; }
        public List<Operation> operation { get; set; }



        public WORKER(Guid id, string name, string surname, int age, string position, int salary, DateTime startTime, DateTime endTime, List<Operation> operations) : base(id, name, surname, age, position, salary)
        {

            this.startTime = startTime;

            this.endTime = endTime;

            this.operation = operations;
        }

        public WORKER()
        {
        }


        public void addOperation(Operation operation)
        {

            this.operation.Add(operation);

        }








    }
}