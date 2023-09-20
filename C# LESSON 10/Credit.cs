using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace C__LESSON_10
{
    public class Credit
    {


        public Guid Id { get; set; }
        public Client Client { get; set; }
        public double Amount { get; set; }
        public double percent { get; set; }
        public string months { get; set; }
        public string payment { get; set; }


        public Credit(Guid id, Client client, double amount, double percent, string months, string payment)
        {
            Id = id;
            Client = client;
            Amount = amount;
            this.percent = percent;
            this.months = months;
            this.payment = payment;
        }


        public Credit()
        {

        }

        public void cP() { Console.WriteLine((Amount * 100) / percent); }

        public void show()
        {
            Console.WriteLine($"Ii {Id}\n");
            Client.show();
            Console.WriteLine($"Amount {Amount}");
            Console.WriteLine($"Precent {percent}");
            Console.WriteLine($"Months {months}");
            Console.WriteLine($"Payment {payment}");



        }

    }
}