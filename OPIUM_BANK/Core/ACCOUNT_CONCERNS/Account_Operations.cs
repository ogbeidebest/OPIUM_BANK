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
    public class Account_Operations:Create_Account 
    {
        public static void CurrentMethod( User_Model users)
        {
            Console.Clear();
            Error_Handling.Heading();
            Console.WriteLine("1: Deposit");
            Console.WriteLine("2: Withdrawal");
            Console.WriteLine("3: Transfer");
            Console.WriteLine("4: Check Balance");
            Console.WriteLine("5: Print Details");
            Console.WriteLine("6: Print Statement");
            Console.WriteLine("7: Log Out");
            Console.WriteLine();
            Console.Write("Please Enter a Reply Here: ");
            string Reply = Console.ReadLine();

            while ( Reply != "1" && Reply != "2" && Reply != "3" && Reply != "4" && Reply != "5" && Reply != "6" && Reply != "7" )
            {
                Error_Handling.TryAgain("Inavalid Response, Please Try With a Valid Response");
                Reply = Console.ReadLine();
            }

            switch (Reply)
            {
                case "1":
                    Console.Clear();
                    Background_Color.colorMagenta("OPIUM BANK");
                    deposit.DepositM(users);
              
                    break;
                case "2":
                    Console.Clear();
                    Background_Color.colorMagenta("OPIUM BANK");
                    Withdraw.Withdrawal(users);
                   
                    break;
                case "3":

                    Console.Clear();
                    Background_Color.colorMagenta("OPIUM BANK");
                    Transfer.TransferMoney(users);
                   
                    break;
                case "4":
                    Console.Clear();
                    Background_Color.colorMagenta("OPIUM BANK");
                    GetBalance.GetBal(users);
              
                    break;
                case "5":
                    Console.Clear();
                    Background_Color.colorMagenta("OPIUM BANK");
                    GetAccountDetails.GetAccountDetail(users);
                 
                    break ;
                case "6":
                    Console.Clear();
                    Background_Color.colorMagenta("OPIUM BANK");
                    GetAccountStatement.AccountStatment(users);
                
                    break;
                case "7":
                    Main_Display.ShowBankDisplay();
                    Error_Handling.BackMain(users);
                    break;

                default:
                    Error_Handling.BackMain(users);
                    break;

            }
        }
    }
}
