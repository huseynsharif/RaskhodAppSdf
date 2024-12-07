using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using RaskhodApp.Models2;


namespace RaskhodApp.business
{
    internal class ExpensesTypeManager
    {
        private readonly MyDbContext2 _dbContext;

        public ExpensesTypeManager(MyDbContext2 dbContext)
        {
            _dbContext = dbContext;
        }

        public void Add(string title)
        {
            ExpenseType e = new ExpenseType(title);
            _dbContext.ExpenseTypes.Add(e);
            _dbContext.SaveChanges();
        }
    }
}
