using OPIUM_BANK.Core.MODELS;
using OPIUM_BANK.Core.UTILITIES;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OPIUM_BANK.Core.ACCOUNT_CONCERNS
{
    public class GetAccountDetails:Create_Account
    {
        public static void GetAccountDetail (User_Model users)
        {
            var Table = new Print_Table("ACCOUNT NUMBER", "ACCOUNT NAME", "ACCOUNT TYPE", "BALANCE");
            Console.WriteLine($"ACCOUNT DETAILS FOR {users.FullName}");
            foreach (var item in CustomerAccount)
            {
                if (item.account.Email == users.Email)
                {
                    Table.AddRow(item.account.AccountNumber, users.FullName, item.account.AccountType, item.account.Balance);
                }
            }

            Table.Print();
            Error_Handling.BackMain(users);
        }
    }
}
