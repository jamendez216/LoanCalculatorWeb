using LoanCalculatorBusinessLogic.BusinessLogic;
using LoanCalculatorDataAccess.Models;
using LoanCalculatorWeb.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace LoanCalculatorWeb.Controllers
{
    public class HomeController : Controller
    {
        public ActionResult Index()
        {
            return View();
        }

        public ActionResult About()
        {
            ViewBag.Message = "This is a web Loan Calculator";

            return View();
        }

        public ActionResult Contact()
        {
            ViewBag.Message = "You can contact me here.";

            return View();
        }

        public ActionResult LoanCalculator()
        {
            ViewBag.Message = "The page for the Loan Calculator!";

            return View(new ViewModelLoanGenerator());
        }

        public ActionResult CreateLoan(ViewModelLoanGenerator viewModelLoan)
        {
            try
            {
                ViewData.Clear();
                var Monthpayment = new LoanBusinessLogic().GenerateLoan(new ViewModelLoan
                {
                    BirthDate = viewModelLoan.BirthDate,
                    Amount = viewModelLoan.Amount,
                    Months = viewModelLoan.Months,
                    UserLog = viewModelLoan.Name
                });

                ViewBag.result = "Record Inserted Successfully!";
                ViewBag.MonthPayment = Monthpayment;
                
                return View("LoanDetail", new ViewModelLoanDetail() 
                {
                    Amount = viewModelLoan.Amount,
                    MonthPayment = Monthpayment,
                    Months = viewModelLoan.Months,
                    Name = viewModelLoan.Name
                });
            }
            catch (Exception e)
            {
                ViewBag.Error = e.Message;
                return View("LoanCalculator", new ViewModelLoanGenerator());
            }
           
        }

        public ActionResult GetAllLoans()
        {
            var Loans = new LoanBusinessLogic().GetLoans();
            ViewBag.result = "Record Inserted Successfully!";
            return View(Loans.Select(x=> new LoanListViewModel() 
            {
                ID = x.ID,
                Age = x.AGE.Value,
                Amount = x.AMOUNT.Value,
                GeneratedAt = x.QUERY_DATE.Value,
                MonthlyPayment = x.MONTHLY_PAYMENT.Value,
                Months = x.MONTHS.Value,
                ClientName = x.QUERY_IP
            }));
        }

        public ActionResult LoanDetail()
        {
            return View();
        }

    }
}