using System;
using System.Collections.Generic;

namespace ClientPortal.Models
{
    public enum TypeOfAccount
    {
        Cash,
        Savings,
        Expense,
        Income
    }
    public class Owner
    {
        public string customerInfo { get; set; }
    }
}
