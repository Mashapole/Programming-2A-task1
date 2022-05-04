using System;
using System.Collections.Generic;
using System.Text;

namespace Tshepiso
{
    public class BuyProperty: Expenses
    {

        private double PurchasePrice;
        private double TotalDeposit;
        private double InterestRate;
        private double NumberOfMonths;


        public BuyProperty() { }

        public BuyProperty(double purchasePrice, double totalDeposit, double interestRate,double numberOfmonth) 
        {
            this.PurchasePrice = purchasePrice;
            this.TotalDeposit = totalDeposit;
            this.InterestRate = interestRate;
            this.NumberOfMonths = numberOfmonth;
        
        }

        public void setPurchasePrice()
        {
         Console.Write("ENTER PURCHASE PRICE OF THE PROPERTY: R ");

        return;
        }
        public void setTotalDeposit()
        {
         Console.Write("ENTER TOTAL DEPOSIT: R ");

        return;
        }
        public void setTotalInterest()
        {
            Console.Write("ENTER INTERST RATE IN PERSENTAGE: R ");

            return;
        }
        public void setNumberOfMonth()
        {
            Console.Write("ENTER MONTHS TO REPAY(BETWEEN240 and 360): ");

            return;
        }

        public double getPurchasePrice()
        {
            return PurchasePrice;
        }
        public double getTotalDeposit()
        {
            return TotalDeposit;
        }
        public double getTotalInteret()
        {
            return InterestRate;
        }
        public double getNumberOfMonth()
        {
            return NumberOfMonths;
        }

        public override double Expenses_Calcu()
        {

            double monthlyHomeLoans = 0;

            InterestRate = InterestRate / 100 / 12;
            monthlyHomeLoans = (PurchasePrice - TotalDeposit) * (InterestRate * Math.Pow(1 + InterestRate, NumberOfMonths)
                / (Math.Pow(1 + InterestRate, NumberOfMonths) - 1));

            return monthlyHomeLoans;
        }      
}

}

