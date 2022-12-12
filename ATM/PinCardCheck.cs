using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ATM
{
    public class PinCardCheck
    {
        cardHolder currentUser;
        List<cardHolder> cardHolders = new List<cardHolder>();
        String debitCardNum = "";
        
        //public void CardCheck()
        //{
        //    // En while för om de inte skriver in rätt kortnummer
        //    while (true)
        //    {
        //        try
        //        {
        //            Console.Write("> ");
        //            debitCardNum = Console.ReadLine();
        //            currentUser = cardHolders.FirstOrDefault(a => a.cardNum == debitCardNum);
        //            if (currentUser != null) { break; }
        //            else { Console.WriteLine("Card not found. Please try again."); }
        //        }
        //        catch { Console.WriteLine("Please enter a valid card number."); }
        //    }
        //}

        public void PinCheck()
        {
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
        }
    }
}
