using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace FinalGroupProjectTeam8.Models
{
    [Table("IRAs")]
    public class IRA : BankAccount
    {
        public Int32 IRAID { get; set; }

        public virtual AppUser User { get; set; }

        public IRA()
        {

            // Setting the type on instantiation so we can be sure type is always properly set
            this.AccountType = AccountTypeEnum.IRA;
        }
    }
}