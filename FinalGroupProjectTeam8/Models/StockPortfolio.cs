using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace FinalGroupProjectTeam8.Models
{
    public class StockPortfolio : BankAccount
    {
        public Int32 StockPortfolioID { get; set; }

        public virtual AppUser User { get; set; }


        public StockPortfolio()
        {

            // Setting the type on instantiation so we can be sure type is always properly set
            this.AccountType = AccountTypeEnum.StockPortfolio;
        }
    }
}