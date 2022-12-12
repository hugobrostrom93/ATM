using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ATM
{
    public class cardHolder
    {
        cardHolder currentUser;        
        String debitCardNum = "";
        List<cardHolder> cardHolders = new List<cardHolder>();


        public string cardNum { get; set; }
        public int pin { get; set; }
        public string firstName { get; set; }
        public string lastName { get; set; }
        public double balance { get; set; }


        public cardHolder(String cardNum, int pin, String firstName, String lastName, double balance)
        {
            this.cardNum = cardNum;
            this.pin = pin;
            this.firstName = firstName;
            this.lastName = lastName;
            this.balance = balance;
        }
       
        public void Users()
        {
            List<cardHolder> cardHolders = new List<cardHolder>();
            cardHolders.Add(new cardHolder("123456789", 1234, "John", "Doe", 123241.22));
            cardHolders.Add(new cardHolder("234523653", 2345, "Jane", "Miller", 23220.16));
            cardHolders.Add(new cardHolder("325677252", 2757, "Lea", "Killua", 324235.86));
            cardHolders.Add(new cardHolder("324698345", 1874, "Hugo", "Jensen", 135760.54));
            cardHolders.Add(new cardHolder("808756325", 8643, "Kim", "Axei", 23054.63));
        }

        public void hej()
        {
            Console.WriteLine("hejejhehejjejehej");
        }

        public void CardCheck()
        {
            // En while för om de inte skriver in rätt kortnummer
            while (true)
            {
                try
                {
                    Console.Write("> ");
                    debitCardNum = Console.ReadLine();
                    currentUser = cardHolders.FirstOrDefault(a => a.cardNum == debitCardNum);
                    if (currentUser != null) { break; }
                    else { Console.WriteLine("Card not found. Please try again."); }
                }
                catch { Console.WriteLine("Please enter a valid card number."); }
            }
        }
    }
}
