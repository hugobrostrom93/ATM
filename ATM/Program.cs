using System;

public class cardHolder
{
    String cardNum;
    int pin;
    String firstName;
    String lastName;
    double balance;

    public cardHolder(String cardNum, int pin, String firstName, String lastName, double balance)
    {
        this.cardNum = cardNum;
        this.pin = pin;
        this.firstName = firstName;
        this.lastName = lastName;
        this.balance = balance;
    }

    public string getNum()
    {
        return cardNum;
    }

    public int getPin()
    {
        return pin;
    }

    public string getFirstName()
    {
        return firstName;
    }

    public string getLastName()
    {
        return lastName;
    }

    public double getBalance()
    {
        return balance;
    }

    public void setBalance(double balance)
    {
        this.balance = balance;
    }

    public void setPin(int pin)
    {
        this.pin = pin;
    }

    public void setFirstName(String firstName)
    {
        this.firstName = firstName;
    }

    public void setLastName(String lastName)
    {
        this.lastName = lastName;
    }

    public void setCardNum(String cardNum)
    {
        this.cardNum = cardNum;
    }

    public static void Main(String[] args)
    {
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
            Console.WriteLine("How much $$ would you like to deposit?");
            // Eventuellt en try catch här
            double deposit = Double.Parse(Console.ReadLine());
            currentUser.setBalance(currentUser.getBalance() + deposit);
            Console.WriteLine("Thank you for your $$. Your new balance is: " + currentUser.getBalance());
        }

        void withdraw(cardHolder currentUser)
        {
            Console.WriteLine("How much $$ would you like to withdraw?");
            double withdraw = Double.Parse(Console.ReadLine());
            // Check if user has enough money to witdraw
            if (currentUser.getBalance() > withdraw)
            {
                currentUser.setBalance(currentUser.getBalance() - withdraw);
                Console.WriteLine("Here is your " + withdraw + " USD. Your new balance is: " + currentUser.getBalance() + " USD");
            }
            else
            {
                Console.WriteLine("You do not have enough money to withdraw that amount. You have " + currentUser.getBalance() + " USD in your account.");
            }
        }

        void balance(cardHolder currentUser)
        {
            Console.WriteLine("Your current balance is: " + currentUser.getBalance() + " USD");
        }

        List<cardHolder> cardHolders = new List<cardHolder>();
        cardHolders.Add(new cardHolder("123456789", 1234, "John", "Doe", 123241.22));
        cardHolders.Add(new cardHolder("234523653", 2345, "Jane", "Miller", 23220.16));
        cardHolders.Add(new cardHolder("325677252", 2757, "Lea", "Killua", 324235.86));
        cardHolders.Add(new cardHolder("324698345", 1874, "Hugo", "Jensen", 135760.54));
        cardHolders.Add(new cardHolder("808756325", 8643, "Kim", "Axei", 23054.63));

        // Promt user
        Console.WriteLine("Welcome to the ATM!");
        Console.WriteLine("Please enter your debitcard: ");
        String debitCardNum = "";
        cardHolder currentUser;

        while (true)
        {
            try
            {
                debitCardNum = Console.ReadLine();
                currentUser = cardHolders.FirstOrDefault(a => a.cardNum == debitCardNum);
                if (currentUser != null) { break; }
                else { Console.WriteLine("Card not found. Please try again."); }
            }
            catch { Console.WriteLine("Card not found. Please try again."); }
        }

        Console.WriteLine("Please enter your pin: ");
        int userPin = 0;
        while (true)
        {
            try
            {
                userPin = int.Parse(Console.ReadLine());                
                if (currentUser.getPin() == userPin) { break; }
                else { Console.WriteLine("Incorrect pin. Please try again."); }
            }
            catch { Console.WriteLine("Incorrect pin. Please try again."); }
        }

        Console.WriteLine("Welcome " + currentUser.getFirstName() + " " + currentUser.getLastName() + "!");
        int option = 0;
        do
        {
            printOptions();
            try
            {
                option = int.Parse(Console.ReadLine());
            }
            catch{ }
            if (option == 1) { deposit(currentUser); }
            else if (option == 2) { withdraw(currentUser); }
            else if (option == 3) { balance(currentUser); }
            else if (option == 4) { break; }
           // else { option == 0; }
        }
        while(option != 4);
        Console.WriteLine("Thank you have a nice day!");
    }
}
