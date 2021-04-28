using LoanCalculatorDataAccess.DataManagement;
using LoanCalculatorDataAccess.DbContext;
using LoanCalculatorDataAccess.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LoanCalculatorBusinessLogic.BusinessLogic
{
    public class LoanBusinessLogic
    {

        public decimal GenerateLoan(ViewModelLoan viewModelLoan)
        {
            viewModelLoan.Age= DateTime.Now.Year - viewModelLoan.BirthDate.Year;

            if (viewModelLoan.BirthDate.Date > DateTime.Now.AddYears(-viewModelLoan.Age.Value)) viewModelLoan.Age--;
            if (viewModelLoan.Age < 18) throw new Exception("Lo sentimos, aun no cuenta con la edad para solicitar este producto.");
            if (viewModelLoan.Age > 25) throw new Exception("Favor pasar por una de nuestras sucursales para evaluar su caso.");
            if (!viewModelLoan.Months.HasValue) throw new Exception("Especifique la cantidad de meses del prestamo");
            if (string.IsNullOrEmpty(viewModelLoan.UserLog)) throw new Exception("Especifique a nombre de quien esta el prestamo");

            return new LoanManagement().GenerateLoan(viewModelLoan);
        }

        public List<QUERY_LOG> GetLoans()
        {
            return new LoanManagement().GetLoans();
        }
    }
}
