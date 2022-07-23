using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OPIUM_BANK.Core.MODELS
{
    public class User_Model
    {
        public string User_Id { get; set; } = Guid.NewGuid().ToString();
        public string FullName { get; set; }

        public string Email { get; set; }

        public string Password { get; set; }
    }
}
