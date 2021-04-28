using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Web;

namespace LoanCalculatorWeb.Models
{
    public class LoanListViewModel
    {
        public int ID { get; set; }
        [DisplayName("Generated At")]
        public DateTime GeneratedAt { get; set; }
        public int Age { get; set; }
        public decimal Amount { get; set; }
        public int Months { get; set; }
        [DisplayName("Monthly Payment")]
        public decimal MonthlyPayment { get; set; }
        [DisplayName("Client Name")]
        public string ClientName { get; set; }
    }
}

/*
 ID int primary key identity,
	QUERY_DATE datetime,
	AGE int,
	AMOUNT decimal(20,2),
	MONTHS int,
	MONTHLY_PAYMENT decimal(12,2),
	QUERY_IP VARCHAR(50)
 */