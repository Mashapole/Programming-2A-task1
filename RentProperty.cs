using System;
using System.Collections.Generic;
using System.Text;

namespace Tshepiso
{
    public class RentProperty : Expenses
    {
        private double rentAmount;

        public RentProperty()
        {

        }
        public RentProperty(double amount)
        {
            this.rentAmount = amount;
        }

        public void setRentingAmount()
        {
            Console.Write("ENTER MONTHLY RENTAL AMOUNT: R");

            return;
        }
        public override double Expenses_Calcu()
        {
         
            return (double) rentAmount;
        }
    }
}
