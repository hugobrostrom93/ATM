using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ATM
{
    public class ATM
    {
        public void deposit(cardHolder currentUser)
        {
            Console.Clear();
            Console.WriteLine("How much $$ would you like to deposit?");
            // Eventuellt en try catch här

            while (true)
            {
                try
                {
                    double deposit = Double.Parse(Console.ReadLine());
                    currentUser.balance = currentUser.balance + deposit;

                    if (currentUser.balance != null) { break; }
                    else { Console.WriteLine("Please enter a valid number:"); }
                }
                catch { Console.WriteLine("Please enter a valid number:"); }
            }

            Console.WriteLine($"Thank you for your $$. Your new balance is: {currentUser.balance} USD\n");
        }
        public void withdraw(cardHolder currentUser)
        {
            Console.Clear();
            Console.WriteLine($"How much $$ would you like to withdraw? Your current balance is {currentUser.balance}");

            while (true)
            {
                try
                {
                    Console.Write("> ");
                    double withdraw = Double.Parse(Console.ReadLine());
                    if (currentUser.balance > withdraw)
                    {
                        currentUser.balance = currentUser.balance - withdraw;
                        Console.WriteLine($"Here is your {withdraw} USD. Your new balance is: {currentUser.balance} USD\n");
                        break;
                    }
                    else if (currentUser.balance < withdraw)
                    {
                        Console.WriteLine($"You do not have enough money to withdraw that amount. You have {currentUser.balance} USD in your account.\n");
                        Console.WriteLine("> Please enter a new ammount");
                    }
                    // else { Console.WriteLine($"Please enter a correct number: \n"); }
                }
                catch { Console.WriteLine($"> Please enter a correct number"); }
            }
        }
        public void balance(cardHolder currentUser)
        {
            Console.Clear();
            Console.WriteLine($"Hello {currentUser.lastName}!");
            Console.WriteLine($"Your current balance is: {currentUser.balance} USD\n");
        }
    }
}
