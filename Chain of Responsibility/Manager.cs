using System;
using System.Collections.Generic;
using System.Text;

namespace Chain_of_Responsibility
{
    public class Manager : ExpenseHandlerBase
    {
        public override void HandleExpense(Expense expense)
        {
            if (expense.Amount <= 100)
            {
                Console.WriteLine("Manager Handled the Expense !");
            }
            else if (Successor != null)
            {
                Successor.HandleExpense(expense);
            }
        }
    }
}
