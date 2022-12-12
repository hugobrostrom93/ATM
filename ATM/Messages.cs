using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ATM
{
    
    public class Messages
    {
        cardHolder currentUser;
        PinCardCheck pinCardCheck = new PinCardCheck();
        MenyVal menyVal;

        public void WelcomeMessage()
        {
            Console.WriteLine("+-----------------------------------------+");
            Console.WriteLine("|         Welcome to the HUGO ATM!        |");
            Console.WriteLine("|   Please enter your debitcard number    |");
            Console.WriteLine("+-----------------------------------------+");
            currentUser.hej();
            pinCardCheck.PinCheck();
            UserWelcome();
        }

        public void UserWelcome()
        {
            Console.Clear();
            Console.WriteLine("+---------------------------------------------------+");
            Console.WriteLine($"         Welcome {currentUser.firstName} {currentUser.lastName} to the HUGO ATM!");
            Console.WriteLine("     Please select one of the four options below:");
            Console.WriteLine("+---------------------------------------------------+");
            printOptions();
        }

        public void printOptions()
        {
            Console.WriteLine("Please choose one of the following options...");
            Console.WriteLine("1. Deposit");
            Console.WriteLine("2. Withdraw");
            Console.WriteLine("3. Show Balance");
            Console.WriteLine("4. Exit");
            menyVal.Logic();            
        }
    }

}
