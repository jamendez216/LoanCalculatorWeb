using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LoanCalculatorDataAccess.Models
{
    public class ViewModelLoan
    {
        public DateTime BirthDate { get; set; }
        public short? Months { get; set; }
        public decimal? Amount { get; set; }

        public int? Age { get; set; }
        public string UserLog { get; set; }

    }
}
