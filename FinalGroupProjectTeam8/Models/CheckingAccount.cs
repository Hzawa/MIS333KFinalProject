using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace FinalGroupProjectTeam8.Models
{
    public class CheckingAccount : CashAccount
    {
        public Int32 CheckingAccountID { get; set; }

        [Key]
        public String UserID { get; set; }

        [ForeignKey("UserID")]
        public virtual AppUser User { get; set; }

        public CheckingAccount() {

            // Setting the type on instantiation so we can be sure type is always properly set
            this.AccountType = AccountTypeEnum.CheckingAccount;
        }

    }
}