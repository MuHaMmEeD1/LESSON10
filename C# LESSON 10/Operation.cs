using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace C__LESSON_10
{
    public class Operation
    {


        public Guid Id { get; set; }

        public List<DateTime> p_d { get; set; }

        public Operation(Guid id, List<DateTime> p_d)
        {
            Id = id;
            this.p_d = p_d;
        }


        public Operation()
        {

        }

    }
}