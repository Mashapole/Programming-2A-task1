using System;

namespace Tshepiso
{
    class Program
    {
        public static void Main(string[] args)
        {
            Boolean condition = false;


            
            while (!condition)
            {
                try
                {

                    Expenditures espenses = new Expenditures();

                    double[] expenditure = new double[7];

                    Console.WriteLine("ENTER THE FOLLOWING VALUES:");
                    espenses.setMonthlyIncome();
                    expenditure[0] = double.Parse(Console.ReadLine());

                    espenses.setMonthTax();
                    expenditure[1] = double.Parse(Console.ReadLine());

                    espenses.setGroceries();
                    expenditure[2] = double.Parse(Console.ReadLine());

                    espenses.setWaterAndLight();
                    expenditure[3] = double.Parse(Console.ReadLine());

                    espenses.setTravelAndCost();
                    expenditure[4] = double.Parse(Console.ReadLine());

                    espenses.setTelephone();
                    expenditure[5] = double.Parse(Console.ReadLine());

                    espenses.setOtherExpense();
                    expenditure[6] = double.Parse(Console.ReadLine());

                    //refresh and send to data to class for calculations
                     espenses = new Expenditures(expenditure[0], expenditure[1], expenditure[2], expenditure[3], expenditure[4], expenditure[5], expenditure[6]);
                    double RemainingAmount = 0.0;
                    Console.WriteLine("");
                    Console.WriteLine("ARE YOU RENTING ACCOMODATION OR BUYING PROPERTY ? \n " +
                                 "Choose (1) FOR RENTING PROPERTY \n  " +
                                 "Choose (2) FOR BUYING PROPERTY");

                    switch (Console.ReadLine())

                    {
                        default:
                            Environment.Exit(0);
                            return;

                        case "1":

                            expenditure = new double[1];
                            RentProperty rentProperty = new RentProperty();
                            Console.WriteLine("");
                            rentProperty.setRentingAmount();
                            expenditure[0] = double.Parse(Console.ReadLine());

                            //refresh and send to data to class for calculations
                            rentProperty = new RentProperty(expenditure[0]);

                            if(rentProperty.Expenses_Calcu()< espenses.getMonthIncome())
                            {
                                Console.WriteLine("");
                                RemainingAmount =espenses.getMonthIncome()-(espenses.Expenses_Calcu()+rentProperty.Expenses_Calcu());
                                Console.WriteLine("the approval of Rent is likely");
                                /*Display report */
                                Console.Write("REMAINING AMOUNT IS: R" + RemainingAmount);
                                return;
                            }
                            else
                            {
                                Console.WriteLine("Rent payment is more than a third of the user’s gross monthly income,the approval of is unlikely");

                                return;
                            }


                          
                        case "2":

                            BuyProperty buyProperty = new BuyProperty();
                            expenditure = new double[4];

                            Console.WriteLine("");
                            buyProperty.setPurchasePrice();
                            expenditure[0] = double.Parse(Console.ReadLine());
                            buyProperty.setTotalDeposit();
                            expenditure[1] = double.Parse(Console.ReadLine());
                            buyProperty.setTotalInterest();
                            expenditure[2] = double.Parse(Console.ReadLine());
                            buyProperty.setNumberOfMonth();
                            expenditure[3] = double.Parse(Console.ReadLine());

                            //refresh and send to data to class for calculations
                            buyProperty = new BuyProperty(expenditure[0], expenditure[1], expenditure[2], expenditure[3]);

                            if (buyProperty.getNumberOfMonth() >= 240 && buyProperty.getNumberOfMonth() <= 360)
                            {

                                if (buyProperty.Expenses_Calcu() > espenses.getMonthIncome())
                                {
                                    Console.WriteLine("Homeloan payment is more than a third of the user’s gross monthly income,the approval of is unlikely");

                                    return;
                                }
                                else
                                {
                                Console.WriteLine("");
                                Console.WriteLine("Homeloan payment approval is likely");
                                RemainingAmount = 0.0;
                                RemainingAmount = espenses.getMonthIncome() - (espenses.Expenses_Calcu() + buyProperty.Expenses_Calcu());
                                /*Display report */
                                Console.Write("REMAINING AMOUNT IS: R" + RemainingAmount);

                                    return;
                                }
                            }

                            break;

                      
                    }

                }

                catch (Exception error)
                {
                Console.WriteLine("INVELID INPUT PLEASE TRY AGAIN!!!!" + error.Message);
                continue;
                
                }

                }
            }
 }
}
    

