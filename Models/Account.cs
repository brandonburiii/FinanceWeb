using Microsoft.AspNetCore.Mvc;
using System.ComponentModel.DataAnnotations;

namespace FinanceWeb.Models
{
   
        public class User
        {
            public int UserId { get; set; }
            [MaxLength(100)]
            public string Username { get; set; }
            public string Email { get; set; }
            public int Password { get; set; }

            public User()
            {

            }
        }

    
}
