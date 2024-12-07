using System;
using System.Collections.Generic;

namespace RaskhodApp.Models2;

public partial class Expense
{
    public int Id { get; set; }

    public int UserId { get; set; }

    public DateTime Date { get; set; }

    public int ExpenseTypeId { get; set; }

    public double Amount { get; set; }

    public virtual ExpenseType ExpenseType { get; set; } = null!;

    public virtual User User { get; set; } = null!;

    public Expense(int userId, DateTime date, int expenseTypeId, double amount)
    {
        UserId = userId;
        Date = date;
        ExpenseTypeId = expenseTypeId;
        Amount = amount;
    }
}
