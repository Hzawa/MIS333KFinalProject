using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace FinalGroupProjectTeam8.Models
{
    public class Transaction
    {
        
        public enum TransactionTypeEnum { Withdrawal, Deposit, Transfer, Payment }
        public TransactionTypeEnum TransactionType { get; set; }

        public String TransactionID { get; set; }
        public String AccountID { get; set; }

        [Display(Name = "Description")]
        [Required(ErrorMessage = "Description is required.")]
        public String Description { get; set; }

        [Display(Name = "Amount")]
        [Required(ErrorMessage = "Amount is required.")]
        public Decimal Amount { get; set; }

        public String Comments { get; set; }
        public DateTime Date { get; set; }

    }
}