using OPIUM_BANK.Core.MODELS;
using OPIUM_BANK.Core.UTILITIES;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OPIUM_BANK.Core.ACCOUNT_CONCERNS
{
    public class deposit:Create_Account
    {
        public static void DepositM(User_Model users)
        {
            
            string AccNum = ViewAccounts.View_accounts(users, CustomerAccount);
            Console.Clear();
            string reply = "";
            Background_Color.colorMagenta("OPIUM BANK");
            Background_Color.colourBlue($"Account Number:{AccNum}");
            foreach (var item in CustomerAccount)
            {
                if (item.account.AccountNumber == AccNum)
                {
                    if (users != null)
                    {
                        Console.Write($"Please Enter the Amount to Deposit to {users.FullName} account: ");
                        string amount1 = Console.ReadLine();

                        decimal amount = Error_Handling.AmountError(Convert.ToDecimal(amount1));

                        if (amount > 300000 && item.account.AccountType == "SAVING")
                        {
                            reply = "Account can not take such large amount. Maximum deposit for a savings account is 300,000";

                        }
                        else
                        {
                            item.Deposit_Money(amount);
                            reply = $"{amount} successfully deposited!";
                            item.AddTransactions(amount, $"Your account was credited with {amount}");
                        }


                    }
                }
            }
            Console.WriteLine(reply);
            Error_Handling.BackMain(users);
        }
    }
}
