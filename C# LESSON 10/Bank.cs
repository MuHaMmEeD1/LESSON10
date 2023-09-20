using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace C__LESSON_10
{
    public class Bank
    {
       

        public string NAME { get; set; }
        public double BUDGET { get; set; }
        public double PROFIT { get; set; }
        public CEO Ceo { get; set; }
        public List<WORKER> Workers { get; set; }
        public List<Client> Clients { get; set; }
        public List<Credit> Credits { get; set; }


        public Bank(string nAME, double bUDGET, CEO ceo)
        {
            NAME = nAME;
            BUDGET = bUDGET;
            Ceo = ceo;
            Workers = new List<WORKER>();
            Clients = new List<Client>();
            Credits = new List<Credit>();
        }

        public Bank() { }

        public void showClientCredit(string fullname) {

            for (int i = 0; i < Clients.Count; i++)
            {
                if (Clients[i].Name == fullname)
                {
                    Clients[i].show();return;
                }
            }
            Console.WriteLine("bele biri yoxdu");
        }

        public void payCredit(Client clent,  double money) {

            for (int i = 0; i < Credits.Count; i++)
            {
                if (Credits[i].Client.Id == clent.Id) { if (Credits[i].Amount <= money) { Credits[i].Amount = 0; BUDGET += money; return; } BUDGET += money; Credits[i].Amount -= money; return; }
            }
        
        }

        public void CALCULATE_PROFIT() { Console.WriteLine((BUDGET/100)*PROFIT); }

        public void showAllCredit()
        {

            for (int i = 0; i < Credits.Count; i++)
            {
                Credits[i].show();
            }

        }

    }
}