using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ATM
{
    public class MenyVal
    {        
        cardHolder currentUser;
        List<cardHolder> cardHolders = new List<cardHolder>();
        Messages messages = new Messages();
        ATM atm = new ATM();
        
        public void Logic()
        {
            int option = 0;

            do
            {
                messages.printOptions();
                option = int.Parse(Console.ReadLine());
                
                if (option == 1) { atm.deposit(currentUser); }
                else if (option == 2) { atm.withdraw(currentUser); }
                else if (option == 3) { atm.balance(currentUser); }
                else if (option == 4) { break; }
                else { Console.WriteLine("Invalid option. Please try again.\n"); }
            }
            while (option != 4);
            Console.WriteLine("Thank you have a nice day!");
        }
    }
}
