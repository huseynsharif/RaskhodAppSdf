using RaskhodApp.Models2;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RaskhodApp.business
{
    internal class ExpenseManager
    {
        private readonly MyDbContext2 _dbContext;

        public ExpenseManager(MyDbContext2 dbContext)
        {
            _dbContext = dbContext;
        }

        public List<Expense> GetAll()
        {
            return _dbContext.Expenses.ToList();
        }
    }
}
