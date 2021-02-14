using System;
using System.Collections.Generic;
using System.Text;

namespace Chain_of_Responsibility
{
    public abstract class ExpenseHandlerBase
    {
        protected ExpenseHandlerBase Successor;
        public abstract void HandleExpense(Expense expense);
        
        public void SetSuccessor(ExpenseHandlerBase successor)
        {
            Successor = successor;
        }
    }
}
