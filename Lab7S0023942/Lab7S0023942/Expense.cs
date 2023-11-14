using System;
using System.Collections.Generic;
using System.Text;

namespace Lab7S0023942
{
    public class Expense
    {
        //properties
        public decimal Amount { get; set; }
        public DateTime ExpenseDate { get; set; }
        public string Category { get; set; }

        //Constructors

        //methods
        public override string ToString()
        {
            return $"{Category} {Amount:C} on {ExpenseDate.ToShortDateString()}";
        }
    }
}
