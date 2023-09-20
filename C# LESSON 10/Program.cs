


using System.Runtime.Intrinsics.X86;

namespace C__LESSON_10;

class Program
{

    static Bank b1 = new Bank(
        
        "1 BANK",
        1000,
        new CEO(new Guid(), "ceo", "ceolu", 20, "pul veren", 2000)
    );


    static void Main(string[] args)
    {

        b1.Credits.Add(new Credit(Guid.NewGuid() , new Client(Guid.NewGuid(), "hesen", "hesenli", 30, "asasas.com","cocococ.com", 3000), 3400, 20, "3","payment"));

        b1.showAllCredit();

    }
}




