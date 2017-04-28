﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace FinalGroupProjectTeam8.Models
{
    public class SavingsAccount : CashAccount
    {
        public SavingsAccount()
        {

            // Setting the type on instantiation so we can be sure type is always properly set
            this.AccountType = AccountTypeEnum.SavingsAccount;
        }
    }
}