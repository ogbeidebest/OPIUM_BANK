using OPIUM_BANK.Core.MODELS;
using OPIUM_BANK.Core.UTILITIES;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OPIUM_BANK.Core.ACCOUNT_CONCERNS
{
    public  class Withdraw: Create_Account
    {
        public static void Withdrawal(User_Model users)
        {
            string AccNums = ViewAccounts.View_accounts(users, CustomerAccount);
            Console.Clear();
            Background_Color.colorMagenta("OPIUM BANK");
            Background_Color.colourBlue($"Account Number:{AccNums}");
            string replys = "";
            foreach (var item in CustomerAccount)
            {
                if (item.account.AccountNumber == AccNums)
                {
                    if (users != null)
                    {
                        Console.Write($"Please Enter the Amount to Withdraw:");
                        string AMTs = Console.ReadLine();
                        decimal AMT = Error_Handling.AmountError(Convert.ToDecimal(AMTs));
                        bool checks = item.Withdrawal(AMT, item.account.AccountType);
                        if (checks)
                        {
                            replys = $"{AMT} successfully Withdraw!";
                            item.AddTransactions(AMT, $"{AMT} was withdrawn");
                        }
                        else
                        {
                            replys = "Insufficient funds";
                        }
                    }

                }
            }
            Error_Handling.SuccessMessage(replys);
            Error_Handling.BackMain(users);
        }
    }
}
