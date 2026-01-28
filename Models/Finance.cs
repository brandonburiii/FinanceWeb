using Microsoft.AspNetCore.Mvc;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Security.Principal;

namespace FinanceWeb.Models
{
   
       

        public class Category
        {
            public int CategoryId { get; set; }
            public string Name { get; set; }
            public string Type { get; set; }

        public List<Transaction> Transactions { get; set; } = new();
        public Category()
            {

            }
        }

        public class Transaction
        {
            public int TransactionId { get; set; }
        [Column(TypeName = "decimal(18,2)")]
        public decimal Amount { get; set; }
            public DateTime Data { get; set; }
            public string Description { get; set; }
            public int CategoryIdD { get; set; }
            public string UserId { get; set; }
            public Transaction()
            {

            }
        }
        public class Budget

        {
            public int BudgetID { get; set; }
            public int CategoryId { get; set; }
        [Column(TypeName = "decimal(18,2)")]
        public decimal MonthlyLimit { get; set; }
            public int Month { get; set; }
            public int Year { get; set; }
        public Category Category { get; set; }


        public Budget()
            {

            }
        }






    
}
