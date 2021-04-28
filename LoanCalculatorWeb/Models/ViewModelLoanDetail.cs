using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Web;

namespace LoanCalculatorWeb.Models
{
    public class ViewModelLoanDetail
    {
        [DisplayName("You will pay monthly")]
        public decimal? MonthPayment { get; set; }
        [DisplayName("From the amount:")]
        public decimal? Amount { get; set; }
        [DisplayName("For this months long")]
        public short? Months { get; set; }
        [DisplayName("Your name is")]
        public string Name { get; set; }
    }
}