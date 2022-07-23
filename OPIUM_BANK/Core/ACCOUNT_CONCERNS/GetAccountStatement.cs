using OPIUM_BANK.Core.MODELS;
using OPIUM_BANK.Core.UTILITIES;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OPIUM_BANK.Core.ACCOUNT_CONCERNS
{
    public class GetAccountStatement: Create_Account
    {
        public static void AccountStatment(User_Model users)
        {
            string CheckAccNos = ViewAccounts.View_accounts(users, CustomerAccount);
            Console.Clear();
            Console.WriteLine($"ACCOUNT STATEMENT ON ACCOUNT NUMBER {CheckAccNos}");
            foreach (var item in CustomerAccount)
            {

                if (item.account.AccountNumber == CheckAccNos)
                {

                    var Tables = new Print_Table("Date", "Description", "Amount", "Balance");
                    var Statement = item.account.TransactionHolder;
                    foreach (var s in Statement)
                    {
                        if (s.AccountNumber == CheckAccNos)
                        {
                            Tables.AddRow(s.Date, s.Description, s.Amount, s.Balance);
                        }
                    }
                    Tables.Print();
                }
            }
            Error_Handling.BackMain(users);
        }
    }
}
