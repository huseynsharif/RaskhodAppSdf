using System;
using System.Collections.Generic;

namespace RaskhodApp.Models2;

public partial class Expense
{
    public int Id { get; set; }

    public int UserId { get; set; }

    public DateOnly Date { get; set; }

    public int ExpenseTypeId { get; set; }

    public double Amount { get; set; }

    public virtual ExpenseType ExpenseType { get; set; } = null!;

    public virtual User User { get; set; } = null!;
}
