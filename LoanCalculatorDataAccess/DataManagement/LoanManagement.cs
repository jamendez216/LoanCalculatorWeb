using LoanCalculatorDataAccess.DbContext;
using LoanCalculatorDataAccess.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Configuration;
using System.Threading.Tasks;

namespace LoanCalculatorDataAccess.DataManagement
{
    public class LoanManagement
    {
        private readonly LoanCalculatorEntities loanCalculatorEntities;
        public LoanManagement()
        {
            this.loanCalculatorEntities = new LoanCalculatorEntities();
        }

        public decimal GenerateLoan(ViewModelLoan viewModelLoan)
        {
            loanCalculatorEntities.INSERT_QUERY_LOG(viewModelLoan.Age, viewModelLoan.Amount, viewModelLoan.Months, viewModelLoan.UserLog);
            return loanCalculatorEntities.QUERY_LOG.FirstOrDefault(x=>x.MONTHS == viewModelLoan.Months && x.QUERY_IP == viewModelLoan.UserLog && x.AGE == viewModelLoan.Age).MONTHLY_PAYMENT.Value;
        }

        public List<QUERY_LOG> GetLoans()
        {
            return loanCalculatorEntities.QUERY_LOG.ToList();
        }
    }
}
