using System;
using System.Collections.Generic;
using System.Text;

namespace Chain_of_Responsibility
{
    public class VicePresident : ExpenseHandlerBase
    {
        public override void HandleExpense(Expense expense)
        {
            if (expense.Amount > 100 && expense.Amount <= 1000)
            {
                Console.WriteLine("Vice President Handled the Expense !");
            }
            else if (Successor != null)
            {
                Successor.HandleExpense(expense);
            }
        }
    }
}

