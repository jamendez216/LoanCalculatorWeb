using LoanCalculatorDataAccess.DbContext;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace LoanCalculatorWeb.Models
{
    public class ViewModelLoanGenerator
    {
        public ViewModelLoanGenerator()
        {
            monthsList = new LoanCalculatorEntities().AVAILABILITY_MONTHS.ToList();
            BirthDate = DateTime.Now;
            Months = 0;
            Amount = 0;
        }
        public DateTime BirthDate { get; set; }
        public short? Months { get; set; }
        public decimal? Amount { get;set; }
        public string Name { get; set; }
        public List<AVAILABILITY_MONTHS> monthsList { get; set; }

    }

}