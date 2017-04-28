using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace FinalGroupProjectTeam8.Models
{
    public class Account
    {
        
        public enum AccountTypeEnum { CheckingAccount, SavingsAccount, IRA, StockPortfolio }
        public AccountTypeEnum AccountType { get; set; }

        public String AccountID { get; set; }
        public String Name { get; set; }
        public Decimal Balance { get; set; }
        public Boolean Active { get; set; }

        public Customer Customer { get; set; }

    }
}