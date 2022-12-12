using ATM;
using System;
//public class Program
//{
//    public static void Main(string[] args)
//    {


//        Messages messages = new Messages();
//        messages.WelcomeMessage();
//    }
//}
public class cardHolder
{

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

    public static void Main(String[] args)
    {
        //Lista på våra kunder:     Kortnummer // PIN // Förnamn // Efternamn // Saldo
        List<cardHolder> cardHolders = new List<cardHolder>();
        cardHolders.Add(new cardHolder("123456789", 1234, "John", "Doe", 123241.22));
        cardHolders.Add(new cardHolder("234523653", 2345, "Jane", "Miller", 23220.16));
        cardHolders.Add(new cardHolder("325677252", 2757, "Lea", "Killua", 324235.86));
        cardHolders.Add(new cardHolder("324698345", 1874, "Hugo", "Jensen", 135760.54));
        cardHolders.Add(new cardHolder("808756325", 8643, "Kim", "Axei", 23054.63));

        Console.WriteLine("+-----------------------------------------+");
        Console.WriteLine("|         Welcome to the HUGO ATM!        |");
        Console.WriteLine("|   Please enter your debitcard number    |");
        Console.WriteLine("+-----------------------------------------+");

        String debitCardNum = "";
        cardHolder currentUser;

        //En while för om de inte skriver in rätt kortnummer
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
            catch { Console.WriteLine("Card not found. Please try again."); }
        }

        // En while för om de inte skriver in rätt pin
        Console.Clear();
        Console.WriteLine($"> Hello {currentUser.firstName} {currentUser.lastName} please enter your PIN to get access to your account ");
        Console.Write($"> Pin goes here: ");
        int userPin = 0;
        while (true)
        {
            try
            {
                userPin = int.Parse(Console.ReadLine());
                if (currentUser.pin == userPin) { break; }
                else { Console.WriteLine("Incorrect pin. Please try again."); Console.Write($"> Pin goes here: "); }
            }
            catch
            {
                { Console.WriteLine("Incorrect pin. Please try again."); Console.Write($"> Pin goes here: "); }
            }
        }

        // Välkomstmeddelande om de skrivit in rätt kortnummer + pin
        Console.Clear();
        Console.WriteLine("+---------------------------------------------------+");
        Console.WriteLine($"         Welcome {currentUser.firstName} {currentUser.lastName} to the HUGO ATM!");
        Console.WriteLine("     Please select one of the four options below:");
        Console.WriteLine("+---------------------------------------------------+");

        int option = 0;

        do
        {
            printOptions();
            option = int.Parse(Console.ReadLine());

            if (option == 1) { deposit(currentUser); }
            else if (option == 2) { withdraw(currentUser); }
            else if (option == 3) { balance(currentUser); }
            else if (option == 4) { break; }
            else { Console.WriteLine("Invalid option. Please try again.\n"); }
        }
        while (option != 4);
        Console.WriteLine("Thank you have a nice day!");


        void printOptions()
        {
            Console.WriteLine("Please choose one of the following options...");
            Console.WriteLine("1. Deposit");
            Console.WriteLine("2. Withdraw");
            Console.WriteLine("3. Show Balance");
            Console.WriteLine("4. Exit");
        }

        void deposit(cardHolder currentUser)
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

        void withdraw(cardHolder currentUser)
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

        void balance(cardHolder currentUser)
        {
            Console.Clear();
            Console.WriteLine($"Hello {currentUser.lastName}!");
            Console.WriteLine($"Your current balance is: {currentUser.balance} USD\n");
        }
    }
}