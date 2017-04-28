﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace FinalGroupProjectTeam8.Models
{
    public class StockPortfolio : Account
    {
        public StockPortfolio()
        {

            // Setting the type on instantiation so we can be sure type is always properly set
            this.AccountType = AccountTypeEnum.StockPortfolio;
        }
    }
}