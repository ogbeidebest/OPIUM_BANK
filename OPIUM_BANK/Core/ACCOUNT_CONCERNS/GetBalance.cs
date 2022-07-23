using OPIUM_BANK.Core.MODELS;
using OPIUM_BANK.Core.UTILITIES;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OPIUM_BANK.Core.ACCOUNT_CONCERNS
{
    public class GetBalance: Create_Account
    {
        public static void GetBal(User_Model users)
        {
            string CheckAccNo = ViewAccounts.View_accounts(users, CustomerAccount);
            Console.Clear();
            Background_Color.colorMagenta("OPIUM BANK");
            Background_Color.colourBlue($"Account Number:{CheckAccNo}");
            string Answer = "";
            foreach (var item in CustomerAccount)
            {
                if (item.account.AccountNumber == CheckAccNo)
                {
                    Answer = $"AccountName: {users.FullName}, \n AccountNumber: {item.account.AccountNumber}\n Account Balance : {item.account.Balance}";
                }
            }
            Error_Handling.SuccessMessage(Answer);
            Error_Handling.BackMain(users);
        }
    }
}
