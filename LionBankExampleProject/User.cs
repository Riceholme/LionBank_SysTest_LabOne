using System;
using System.Collections.Generic;
using System.Text;

namespace LionBankExampleProject
{
    public abstract class User
    {
        public string Username { get; set; }
        public string Password { get; set; }
        public List<Account> Accounts { get; set; }
        public int LoginCounter { get; set; }
        public bool LockedOut { get; set; }
        public decimal LoanSum { get; set; }
        public List<string> Log { get; set; }

    }
}
