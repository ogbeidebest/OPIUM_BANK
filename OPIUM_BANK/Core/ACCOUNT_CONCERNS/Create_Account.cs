using OPIUM_BANK.Core.INTERFACE;
using OPIUM_BANK.Core.MODELS;
using OPIUM_BANK.Core.TRANSACTIONS_MODEL;
using OPIUM_BANK.Core.UTILITIES;
using OPIUM_BANK.UI;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OPIUM_BANK.Core.ACCOUNT_CONCERNS
{
    public class Create_Account
    {

        public static readonly List<Account_Transaction_Methods> CustomerAccount = new();
       

        public static void View(User_Model users)
        {
            Console.Clear();
            Error_Handling.Heading();
            Console.WriteLine("1: Create Account");
            Console.WriteLine("2: Perform Transactions/Operations");
            Console.WriteLine("3: Log Out");
            Console.Write("Please Enter a Reply Here: ");
            string reply = Console.ReadLine();
            while (reply != "1" && reply != "2" && reply != "3")
            {
                Error_Handling.TryAgain("Wrong input format");
                reply = Console.ReadLine();
            }
             
            if (reply == "1")
            {
                Console.Clear();
                Error_Handling.Heading();
                int accountType;

                while (true)
                {
                    Console.Write("Choose Account Type 0 for Saving or 1 for Current: ");
                    string checkTypes = Console.ReadLine();
                    while (checkTypes != "0" && checkTypes != "1")
                    {
                        Background_Color.colorRed("Invalid account Type, type 0 or 1");
                        Console.Write("Enter a valid response here: ");
                        checkTypes = Console.ReadLine();
                    }
                    bool checkType = int.TryParse(checkTypes, out accountType);
                    if (checkType)
                    {
                        break;
                    }
                    
                   
                }
                Console.WriteLine("This will take just a few seconds.");
                Console.WriteLine("Please wait while your account is being created......");
           

                var Create_Account = new Account_Transaction_Methods(users.User_Id, accountType, users.Email);
                CustomerAccount.Add(Create_Account);
                Thread.Sleep(3000); //dramatic pause
                
                Console.Clear();
                Error_Handling.Heading();
                Error_Handling.SuccessMessage($" You have Succeffully created a {Create_Account.account.AccountType} Account");
                Error_Handling.SuccessMessage($"Your Account Number is : {Create_Account.account.AccountNumber}");
                Error_Handling.SuccessMessage($" Your AccountName is: {users.FullName}");
                Error_Handling.SuccessMessage($" Your account balance is:  {Create_Account.account.Balance}");
                Error_Handling.cBack(users);

            }
            else if (reply == "2")
            {
                Account_Operations.CurrentMethod(users);
                Error_Handling.cBack(users);
            }
            else if (reply == "3")
            {
                Main_Display.ShowBankDisplay();
              
                  Error_Handling.cBack(users);
            }

        }
    }
}
