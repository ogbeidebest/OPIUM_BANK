using OPIUM_BANK.Core.MODELS;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OPIUM_BANK.Core.ACCOUNT_CONCERNS
{
    public  class Login_User
    {
       
        public static User_Model User_Login(List<User_Model> Users, string email, string password)
        {
            foreach (var item in Users)
            {
               
                if (item.Email == email && item.Password == password)
                {
                    return item;
                }
            }


            return null;


        }
    }
}
