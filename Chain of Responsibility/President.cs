using System;
using System.Collections.Generic;
using System.Text;

namespace Chain_of_Responsibility
{
    public class President : ExpenseHandlerBase
    {
        public override void HandleExpense(Expense expense)
        {
            if (expense.Amount > 1000)
            {
                Console.WriteLine("President Handled the Expense !");
            }
        }
    }
}
