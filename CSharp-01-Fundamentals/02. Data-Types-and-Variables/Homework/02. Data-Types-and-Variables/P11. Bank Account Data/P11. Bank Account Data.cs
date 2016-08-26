using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
/*
    Description

    A bank account has a holder 
    name (first name, middle name and last name), 
    available amount of money (balance), 
    bank name, 
    IBAN, 
    3 credit card numbers associated with the account. 
    
    Declare the variables needed to keep the information for a single bank account using the appropriate data types and descriptive names.  
 
*/

class BankAccountData
{
    static void Main(string[] args)
    {

        string holderFirstName = "Pesho";             // First Name
        string holderMidName = "Peshov";              // Middle Name
        string holderLastName = "Peshovv";            // Last Name

        decimal holderMoneyUSD = 1234.56m;              // available amount of money (balance)
        string bankName = "UBB";                        // bank name
        string holderIBAN = "BG35684122355456556";      // IBAN

        ulong holderCCardNumber1 = 1234123412341234;    // credit card number 1
        ulong holderCCardNumber2 = 1234123412341235;    // credit card number 2
        ulong holderCCardNumber3 = 1234123412341236;    // credit card number 3       


        Console.WriteLine("First Name: {0}", holderFirstName);
        Console.WriteLine("Middle Name: {0}", holderMidName);
        Console.WriteLine("Last Name: {0}", holderLastName);

        Console.WriteLine("available amount of money (balance): {0} USD", holderMoneyUSD);
        Console.WriteLine("Bank name: {0}", bankName);
        Console.WriteLine("IBAN: {0}", holderIBAN);

        Console.WriteLine("credit card number 1: {0}", holderCCardNumber1);
        Console.WriteLine("credit card number 2: {0}", holderCCardNumber2);
        Console.WriteLine("credit card number 3: {0}", holderCCardNumber3);
        
    }
}

