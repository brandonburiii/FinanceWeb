using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace FinanceWeb.Controllers.Services
{
    public class BudgetService : Controller
    {
        public class ExpenseService
        {
            private readonly MyDbContext _context;

            public ExpenseService(MyDbContext context) { _context = context; }

            public async Task<bool> AddExpenseAsync(decimal amount, int userId)
            {
                // 1. Get the current budget from the DB
                var budget = await _context.Set<Models.Budget>().FirstOrDefaultAsync(b => b.UserId == userId);

                // 2. The Business Rule: Reject if overspending
                if (budget == null || amount > budget.RemainingBalance)
                {
                    // You can throw a custom exception or return false
                    return false;
                }

                // 3. If okay, update the balance and save
                budget.RemainingBalance -= amount;
                await _context.SaveChangesAsync();
                return true;
            }
        }
    }
}
