using OPIUM_BANK.Core.MODELS;
using OPIUM_BANK.Core.TRANSACTIONS_MODEL;
using OPIUM_BANK.Core.UTILITIES;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OPIUM_BANK.Core.ACCOUNT_CONCERNS
{
    public class ViewAccounts
    {
        public static string View_accounts(User_Model users, List<Account_Transaction_Methods> CustomerAccount)
        {
            Console.Clear();
            int counts = 0;
            Background_Color.colorMagenta("WELCOME TO OPIUM BANK");
            Background_Color.colourBlue("PLEASE SELECT AN OPTION FROM THE LIST OF ACCOUNTS");
            int i = 1;

            List<string> accString = new();

            foreach (var item in CustomerAccount)
            {
                if (item.account.Email == users.Email)
                {
                    Console.WriteLine($"{i}:Account Type: {item.account.AccountType}\t   Account Number: {item.account.AccountNumber}");
                    accString.Add(item.account.AccountNumber);
                    i++;
                }
            }
            Background_Color.colourYellow("Select An Account to Access");
            if (accString.Count == 0)
            {
                Background_Color.colorRed("You don not have any account created please, Create an account.");
            }
            else
            {
                Console.Write("Enter a Valid Response Enter: ");



                string great = Console.ReadLine();
                int greatInt;


                while (!int.TryParse(great, out greatInt))
                {
                    Console.Write("Input a Response, Please Try Again with a Valid Number.");
                    great = Console.ReadLine();
                    counts = greatInt - 1;
                }

               
            }
           
        
                return accString[counts];

            Console.Clear();
        }
    }
}
