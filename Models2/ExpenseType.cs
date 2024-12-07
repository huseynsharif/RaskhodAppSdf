using System;
using System.Collections.Generic;

namespace RaskhodApp.Models2;

public partial class ExpenseType
{
    public int Id { get; set; }

    public string Title { get; set; } = null!;

    public virtual ICollection<Expense> Expenses { get; set; } = new List<Expense>();

    public ExpenseType(string title)
    {
        Title = title;
    }
}
