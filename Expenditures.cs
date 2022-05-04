using System;
using System.Collections.Generic;
using System.Text;

namespace Tshepiso
{
    public class Expenditures: Expenses
    {

        private double monthIncome;
        private double monthTax;
        private double groceryAmount;
        private double waterAndLightsAmount;
        private double travelAmount;
        private double cellphoneAndTelephone;
        private double otherAmount;

        public Expenditures()
        {

        }

        public Expenditures(double monthlIncome, double monthTax, double groceryAmount, double waterAndLights, double travelCost, double cellphone, double other)
        {
            this.monthIncome = monthlIncome;
            this.monthTax = monthTax;
            this.groceryAmount = groceryAmount;
            this.waterAndLightsAmount = waterAndLights;
            this.travelAmount = travelCost;
            this.cellphoneAndTelephone = cellphone;
            this.otherAmount = other;
        }

        public void setMonthlyIncome()
        {
         Console.Write("ENTER YOUR MONTHLY INCOME BEFORE DIDUCTION: R ");
         return;
        }
        public void setMonthTax()
        {      
         Console.Write("ENTER TAX  MONTHLY  DEDUCTION: R ");
         return;
        }
        public void setGroceries()
        {
            //Estimated monthly expenditures
         Console.WriteLine("ESTIMATE MONTHLY EXPENDITURE");
         Console.Write("IN GROCERIES: R ");

        return;
        }
        public void setWaterAndLight()
        {
         Console.Write("In WATER AND LIGHTS: R ");

        return;
        }
        public void setTravelAndCost()
        {
         Console.Write("IN TRAVEL COST(INCLUDING PETROL): R ");

         return;
        }
        public void setTelephone()
        {
         Console.Write("IN CELLPHONE AND TELEPHONE: R ");

         return;
        }
        public void setOtherExpense()
        {
         Console.Write("IN OTHEREPENSES: R ");
         return;
        }

        public double getMonthIncome()
        {

         return monthIncome;
        }
        public double getMonthTax()
        {

            return monthTax;
        }
        public double getGroceries()
        {

            return groceryAmount;
        }
        public double getWaterAndLights()
        {

            return waterAndLightsAmount;
        }
        public double getTravelCost()
        {

            return travelAmount;
        }
        public double getTelephone ()
        {

            return cellphoneAndTelephone;
        }

        public double getOtherExpense()
        {

            return otherAmount;
        }


        public override double Expenses_Calcu()
        {
            return (double)  monthTax+groceryAmount+waterAndLightsAmount+travelAmount+cellphoneAndTelephone+otherAmount;
        }
    }
}
    
