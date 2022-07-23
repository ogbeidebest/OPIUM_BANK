using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OPIUM_BANK.Core.MODELS
{
    public class Account_Model
    {
        public string AccountNumber { get; set; }
        public string AccountType { get; set; }
        public decimal Balance { get; set; }
        public string User_Id { get; set; }
        public string Email { get; set; }   
        public List<Transaction_Model> TransactionHolder { get; set; }
    }
}
