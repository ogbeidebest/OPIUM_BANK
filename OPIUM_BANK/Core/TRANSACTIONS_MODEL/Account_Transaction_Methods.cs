﻿using OPIUM_BANK.Core.MODELS;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OPIUM_BANK.Core.TRANSACTIONS_MODEL
{
    public class Account_Transaction_Methods
    {

        public readonly Account_Model account = new Account_Model();
        public Account_Transaction_Methods(string Id, int accountType, string email)
        {
            account.Email = email;
            account.AccountNumber = Account_Number(7);
            account.AccountType = accountType == 0 ? "SAVING" : accountType == 1 ? "CURRENT" : "null"; 
            account.User_Id= Id;
            account.TransactionHolder = new List<Transaction_Model>();

        }

        //adds every transactions perform on an account
        public bool AddTransactions(decimal amount, string description)
        {
            Transaction_Model trans = new()
            {
                AccountNumber = account.AccountNumber,
                Description = description,
                Amount = amount,
                Balance = account.Balance,
                Date = DateTime.Now

            };
            if (trans != null)
            {
                account.TransactionHolder.Add(trans);
                return true;
            }
            return false;
        }

        //Deposit money
        public void Deposit_Money(decimal addAmt)
        {
            account.Balance += addAmt;
        }

    
        //Generates account number for every account created

        private static string Account_Number(int length)
        {
            var random = new Random();
            string str = "";
            for (int i = 0; i < length; i++)
                str = String.Concat(str, random.Next(length).ToString());
            return "001" + str;
        }

        //Withdrawal
        public bool Withdrawal(decimal Out_Going_Amount, string accountType)
        {
            decimal minBalance = accountType == "SAVING" ? 1000 : 0;
            bool chk = true;

            if (Out_Going_Amount <= account.Balance - minBalance)
            {
                account.Balance -= Out_Going_Amount;
            }
            else if (Out_Going_Amount > account.Balance - minBalance)
            {
                chk = false;
            }
            return chk;
        }
    }
}
