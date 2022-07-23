using OPIUM_BANK.Core.MODELS;
using OPIUM_BANK.Core.UTILITIES;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OPIUM_BANK.Core.ACCOUNT_CONCERNS
{
    public class Transfer:Create_Account
    {
        public static void TransferMoney(User_Model users)
        {
            string sender = ViewAccounts.View_accounts(users, CustomerAccount);
           
            Background_Color.colorMagenta("OPIUM BANK");

            Background_Color.colourBlue($"Account Number:{sender}");
            Console.Write("Enter the Receiver's Account Number: ");
            decimal amountSent;
            int receiver;
            string AccountReceiving = Console.ReadLine();
            while (!int.TryParse(AccountReceiving, out receiver))
            {
                Console.Clear();

                Error_Handling.TryAgain("Please input a valid account number");

                AccountReceiving = Console.ReadLine();
            }


            while (AccountReceiving.Length is not 10 and not 11 and not 12 and not 13)
            {
                Error_Handling.TryAgain("Please input a valid account number format. Account number should be in the range of 10 t0 13 digits numbers");

                AccountReceiving = Console.ReadLine();
            }


            Console.Write("Enter the Amount: ");
            string Amount2 = Console.ReadLine();
            amountSent = Error_Handling.AmountError(Convert.ToDecimal(Amount2));

            bool check = false;

            foreach (var item in CustomerAccount)
            {
                if (item.account.AccountNumber == sender)
                {
                    check = item.Withdrawal(amountSent, item.account.AccountType);
                    if (check)
                    {
                        item.AddTransactions(amountSent, $"Send {amountSent} to {AccountReceiving}");

                    }

                }
            }
            Error_Handling.SuccessMessage($"{amountSent} sucessfully transferred to {AccountReceiving}");
            if (check)
            {
                foreach (var item in CustomerAccount)
                {
                    if (item.account.AccountNumber == AccountReceiving)
                    {
                        item.Deposit_Money(amountSent);
                        item.AddTransactions(amountSent, $"Recieved {amountSent} from {sender}");

                    }
                }
            }
            else
            {
                Background_Color.colorRed("Insufficient funds");
            }
            Error_Handling.BackMain(users);
        }
    }
}
