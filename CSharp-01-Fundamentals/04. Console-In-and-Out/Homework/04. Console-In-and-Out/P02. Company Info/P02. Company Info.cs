using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
/********************************************************************************************
    Company info

    Description

    A company has name, address, phone number, fax number, web site and manager. The manager has first name, last name, age and a phone number.
    Write a program that reads the information about a company and its manager and prints it back on the console.
    info	input
    Company name:	Telerik Academy
    Company address:	31 Al. Malinov, Sofia
    Phone number:	+359 888 55 55 555
    Fax number:	
    Web site:	http://telerikacademy.com/
    Manager first name:	Nikolay
    Manager last name:	Kostov
    Manager age:	25
    Manager phone:	+359 2 981 981
    Input

    You will each piece of information about the company on a separate line, in the same order as in the example
    Company name
    Company address
    Phone number
    Fax number
    Web site
    Manager first name
    Manager last name
    Manager age
    Manager phone
    Output

    Print the information the same way as shown in the sample test. Make sure that you print "(no fax)" if an empty line is passed as fax number.
    Constraints

    The input will always be in the described format
    Only the fax number field can be empty, all other fields will have be least one symbol
    Time limit: 0.1s
    Memory limit: 8MB

Sample tests

Input	Output
Telerik Academy
231 Al. Malinov, Sofia
+359 888 55 55 555

http://telerikacademy.com/
Nikolay
Kostov
25
+359 2 981 981
*********************************************************************************************/
namespace P02.Company_Info
{
    class CompanyInfo
    {
        static void Main(string[] args)
        {
            //Input
            
            string companyName = Console.ReadLine();            
            string companyAddress = Console.ReadLine();
            string companyPhoneNumber = Console.ReadLine();            
            string companyFaxNumber = Console.ReadLine();                    
            string companyWebSite = Console.ReadLine();
           
            string managerFirstName = Console.ReadLine();            
            string managerLastName = Console.ReadLine();            
            int managerAge = int.Parse(Console.ReadLine());            
            string managerPhone = Console.ReadLine();

            //Checks
            if (companyFaxNumber.Length == 0 || companyFaxNumber == null)
            {
                companyFaxNumber = "(no fax)";
            }

            //Output
            Console.WriteLine("{0}", companyName);
            Console.WriteLine("Address: {0}", companyAddress);
            Console.WriteLine("Tel. {0}", companyPhoneNumber);
            Console.WriteLine("Fax: {0}", companyFaxNumber);
            Console.WriteLine("Web site: {0}", companyWebSite);

            Console.WriteLine("Manager: {0} {1} (age: {2}, tel. {3})", managerFirstName, managerLastName, managerAge, managerPhone);
        }
    }
}
