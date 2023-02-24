using System;
using System.Collections.Generic;

namespace FinalsProg
{
    class Program
    {
        static List<string> pinInput = new List<string>();
        static List<long> mNumber = new List<long>();
        static List<long> pNumber = new List<long>();
        static List<string> Mmessage = new List<string>();

        public static double balance, mAmount, bills;


        static void Main(string[] args)
        {

            MyPin();
            LogIn();
            







            static void MyPin()
            {
                try
                {
                    Console.WriteLine("-------------------------------------------------");
                    Console.WriteLine("|To create a pin input 4 combination of a number |");
                    Console.WriteLine("-------------------------------------------------");
                    Console.WriteLine("Input your combination");
                    string input = Console.ReadLine();
                    pinInput.Add(input);
                    
                        Console.WriteLine("Successfully Added!");
                        Console.WriteLine("");
                        Console.WriteLine("------------------------------");
                        Console.WriteLine("|      Enter your MPIN        |");
                        Console.WriteLine("------------------------------");
                        string mypin = Console.ReadLine();

                        if (mypin != input)
                        {
                            Console.WriteLine("You inputted the wrong combination! create again!");
                            MyPin();
                        }
                        else
                        {
                            MyBalance();
                        }
                    
                    
                }
                catch (InvalidCastException e)
                {
                    Console.WriteLine("Invalid Input!", e);
                    MyPin();

                }
                }
            static void MyBalance()
            {
                try
                {
                    Console.WriteLine("-------------------------------------------------");
                    Console.WriteLine("|             GCash Hello!                       |");
                    Console.WriteLine("-------------------------------------------------");
                    Console.WriteLine("Enter your balance: ");
                    balance = Convert.ToDouble(Console.ReadLine());
                }
                catch (Exception e)
                {
                    Console.WriteLine("Invalid Input!", e);
                    MyBalance();
                }
            }
            static void LogIn()
            {
                try {
                Console.WriteLine("-------------------------------------------------");
                Console.WriteLine("|             Available Balance                  |");
                Console.WriteLine("-------------------------------------------------");
                Console.WriteLine("$ " + balance);
                Console.WriteLine("1. Send");
                Console.WriteLine("2. Bill");
                Console.WriteLine("3. Transactions");
                Console.WriteLine("4. Exit");
                    Console.WriteLine("Enter your choice");
                string choices = Console.ReadLine();

                    if (choices == "1")
                    {
                        Console.WriteLine("-------------------------------------------------");
                        Console.WriteLine("|                 Express Send                   |");
                        Console.WriteLine("-------------------------------------------------");
                        Console.WriteLine("Send to");
                        Console.WriteLine("Enter your mobile number");
                        long mobilenum = Convert.ToInt64(Console.ReadLine());
                        mNumber.Add(mobilenum);


                        Console.WriteLine("-------------------------------------------------");
                        Console.WriteLine("Amount");

                        Console.WriteLine("Available Balance: PHP " + balance);
                        Console.Write("Enter your amount: ");
                        mAmount = double.Parse(Console.ReadLine());
                        if (mAmount <= balance)
                        {
                            Console.WriteLine("-------------------------------------------------");
                            Console.WriteLine(mobilenum);
                            Console.WriteLine("GCash                    " + balance);
                            Console.WriteLine("You'rea about to send");
                            Console.WriteLine("Amount                   " + mAmount);
                            Console.WriteLine("-------------------------------------------------");
                            Console.WriteLine("Total                    " + mAmount);
                            Console.WriteLine("Type Pay if you want to continue");
                            string pay = Console.ReadLine();

                            if (pay == "Pay" || pay == "pay")
                            {
                                Console.WriteLine("-------------------------------------------------");
                                Console.WriteLine("|                  Payment                       |");
                                Console.WriteLine("-------------------------------------------------");
                                Console.WriteLine("✓ Successfully Sent");
                                Console.WriteLine(mobilenum);
                                balance = balance - mAmount;
                                Console.WriteLine("Total:                             " + balance);
                                Console.WriteLine("Payment Method            Gcash");
                                Console.WriteLine("-------------------------------------------------");
                                LogIn();
                            }
                            else
                            {
                                LogIn();
                            }
                        }
                    
                    


                    }
                  else if (choices == "2")
                    {
                        MyBayarin();
                    }
                  else if (choices == "3")
                    {
                        TransactionBill();
                    }
                  else if (choices == "4")
                    {
                        End();
                    }
                    else
                    {
                        Console.WriteLine("Please input the right choices");
                        LogIn();
                    }

                }
                catch (Exception e)
                {
                    Console.WriteLine("Invalid Input!", e);
                    LogIn();
                }
            }
            static void TransactionBill()
            {
                Console.WriteLine("-------------------------------------------------");
                Console.WriteLine("|             Transaction History                |");
                Console.WriteLine("-------------------------------------------------");
                Console.WriteLine("1. Send Money");
                Console.WriteLine("2. Bill");
                string tChoices = Console.ReadLine();

                if (tChoices == "1")
                {
                    Console.WriteLine("Transfer Details");
                    Console.WriteLine("******************************");
                    Console.Write("Transfer from 09384590395 to ");
                    mNumber.ForEach(Console.WriteLine);
                    Console.WriteLine("Amount                       -" + mAmount);
                    End();
                }
                if (tChoices == "2")
                {
                    Console.WriteLine("Transfer Details");
                    Console.WriteLine("******************************");
                    Console.WriteLine("Pay Bills");
                    Console.Write("Account Number: ");
                    pNumber.ForEach(Console.WriteLine);
                    Console.WriteLine("Amount                       -" + bills);
                    Console.WriteLine("Email: ");
                    Mmessage.ForEach(Console.WriteLine);
                    End();
                }

            }
            static void MyBayarin()
            {
                Console.WriteLine("-------------------------------------------------");
                Console.WriteLine("|                  Pay Bill                      |");
                Console.WriteLine("-------------------------------------------------");
                Console.WriteLine("Categories");
                Console.WriteLine("1. Electric Utilities");
                Console.WriteLine("2. Water Utilities");
                Console.WriteLine("3. Cable/Internet");
                Console.WriteLine("4. Back");
                string choices = Console.ReadLine();
                if (choices == "1")
                {
                    ElecticBills();
                }
                if (choices == "2")
                {
                    WaterBill();
                }
                if (choices == "3")
                {
                    InternetBill();
                }
                if (choices == "4")
                {
                    LogIn();
                }
                else
                {
                    Console.WriteLine("Invalid Input");
                    MyBayarin();
                }
            }
            static void ElecticBills()
            {
                Console.WriteLine("-------------------------------------------------");
                Console.WriteLine("|                   MERALCO                      |");
                Console.WriteLine("-------------------------------------------------");
                Console.WriteLine("Posting period: within 24 hours");
                Console.WriteLine("-------------------------------------------------");
                Console.WriteLine("Input your amount");
                bills = Convert.ToDouble(Console.ReadLine());
                if (balance >= bills)
                {
                    Console.WriteLine("-------------------------------------------------");
                    Console.WriteLine("          PHP               " + bills);
                    Console.WriteLine("Customer Account Number(CAN)");
                    Console.WriteLine("-------------------------------------------------");
                    Console.WriteLine("Enter or Scan Customer Acount Number");
                    long can = Convert.ToInt64(Console.ReadLine());
                    pNumber.Add(can);
                    Console.WriteLine("Email");
                    Console.WriteLine("-------------------------------------------------");
                    Console.WriteLine("Enter Email Address");
                    string message = Console.ReadLine();
                    Mmessage.Add(message);
                    Console.WriteLine("Type next if you want to next");
                    string next = Console.ReadLine();
                    if (next == "next" || next == "Next")
                    {
                        Console.WriteLine("-------------------------------------------------");
                        Console.WriteLine("|                Pay Bills                       |");
                        Console.WriteLine("-------------------------------------------------");
                        Console.WriteLine("                  MERALCO                        ");
                        Console.WriteLine("                Confirmation                     ");
                        Console.WriteLine("-------------------------------------------------");
                        Console.WriteLine("             You're about to pay                 ");
                        balance = balance - bills;
                        Console.WriteLine("               PHP " + bills + "                  ");
                        Console.WriteLine("Customer Account Number              " + can);
                        Console.WriteLine("Please note that several billers change a service fee.");
                        Console.WriteLine("Type Pay if you want to continue");
                        string pay = Console.ReadLine();
                        if (pay == "pay" || pay == "Pay")
                        {
                            Console.WriteLine("-------------------------------------------------");
                            Console.WriteLine("|                Pay Bills                       |");
                            Console.WriteLine("-------------------------------------------------");
                            Console.WriteLine("               Payment recieve for               ");
                            Console.WriteLine("                    Meralco                        ");
                            Console.WriteLine("                 the amount of                    ");
                            Console.WriteLine("                  php " + bills + "                ");
                            Console.WriteLine("                     GCash                        ");
                            Console.WriteLine("-------------------------------------------------");
                            Console.WriteLine("                    Details                       ");
                            Console.WriteLine("Amount Paid              " + bills);
                            Console.WriteLine("Fee                      php 0.00");
                            Console.WriteLine("Account Number           " + can);
                            Console.WriteLine("This has been processed and your payment will be ");
                            Console.WriteLine("             posted within 24 hours              ");
                            Console.WriteLine("-------------------------------------------------");
                            Console.WriteLine("|                    Done                       |");
                            Console.WriteLine("-------------------------------------------------");
                            MyBayarin();

                        }
                        else
                        {
                            MyBayarin();
                        }
                    }

                }
                else
                {
                    MyBayarin();
                }





            }
            static void WaterBill()
            {
                Console.WriteLine("-------------------------------------------------");
                Console.WriteLine("|               Manila Water                     |");
                Console.WriteLine("-------------------------------------------------");
                Console.WriteLine("Posting period: within 24 hours");
                Console.WriteLine("-------------------------------------------------");
                Console.WriteLine("Input your amount");
                bills = Convert.ToDouble(Console.ReadLine());
                if (balance >= bills)
                {
                    Console.WriteLine("-------------------------------------------------");
                    Console.WriteLine("          PHP               " + bills);
                    Console.WriteLine("Customer Account Number(CAN)");
                    Console.WriteLine("-------------------------------------------------");
                    Console.WriteLine("Enter or Scan Customer Acount Number");
                    long can = Convert.ToInt64(Console.ReadLine());
                    pNumber.Add(can);
                    Console.WriteLine("Email");
                    Console.WriteLine("-------------------------------------------------");
                    Console.WriteLine("Enter Email Address");
                    string message = Console.ReadLine();
                    Mmessage.Add(message);
                    Console.WriteLine("Type next if you want to next");
                    string next = Console.ReadLine();
                    if (next == "next" || next == "Next")
                    {
                        Console.WriteLine("-------------------------------------------------");
                        Console.WriteLine("|                Pay Bills                       |");
                        Console.WriteLine("-------------------------------------------------");
                        Console.WriteLine("                Manila Water                      ");
                        Console.WriteLine("                Confirmation                     ");
                        Console.WriteLine("-------------------------------------------------");
                        Console.WriteLine("             You're about to pay                 ");
                        balance = balance - bills;
                        Console.WriteLine("               PHP " + bills + "                  ");
                        Console.WriteLine("Customer Account Number              " + can);
                        Console.WriteLine("Please note that several billers change a service fee.");
                        Console.WriteLine("Type Pay if you want to continue");
                        string pay = Console.ReadLine();
                        if (pay == "pay" || pay == "Pay")
                        {
                            Console.WriteLine("-------------------------------------------------");
                            Console.WriteLine("|                Pay Bills                       |");
                            Console.WriteLine("-------------------------------------------------");
                            Console.WriteLine("               Payment recieve for               ");
                            Console.WriteLine("                  Manila Water                  ");
                            Console.WriteLine("                 the amount of                    ");
                            Console.WriteLine("                  php " + bills + "                ");
                            Console.WriteLine("                     GCash                        ");
                            Console.WriteLine("-------------------------------------------------");
                            Console.WriteLine("                    Details                       ");
                            Console.WriteLine("Amount Paid              " + bills);
                            Console.WriteLine("Fee                      php 0.00");
                            Console.WriteLine("Account Number           " + can);
                            Console.WriteLine("This has been processed and your payment will be ");
                            Console.WriteLine("             posted within 24 hours              ");
                            Console.WriteLine("-------------------------------------------------");
                            Console.WriteLine("|                    Done                       |");
                            Console.WriteLine("-------------------------------------------------");
                            MyBayarin();
                        }
                        else
                        {
                            MyBayarin();
                        }
                    }
                }
            }
            static void InternetBill()
            {
                Console.WriteLine("-------------------------------------------------");
                Console.WriteLine("|               CONVERGE ICT                     |");
                Console.WriteLine("-------------------------------------------------");
                Console.WriteLine("Posting period: within 24 hours");
                Console.WriteLine("-------------------------------------------------");
                Console.WriteLine("Input your amount");
                bills = Convert.ToDouble(Console.ReadLine());
                if (balance >= bills)
                {
                    Console.WriteLine("-------------------------------------------------");
                    Console.WriteLine("          PHP               " + bills);
                    Console.WriteLine("Customer Account Number(CAN)");
                    Console.WriteLine("-------------------------------------------------");
                    Console.WriteLine("Enter or Scan Customer Acount Number");
                    long can = Convert.ToInt64(Console.ReadLine());
                    pNumber.Add(can);
                    Console.WriteLine("Email");
                    Console.WriteLine("-------------------------------------------------");
                    Console.WriteLine("Enter Email Address");
                    string message = Console.ReadLine();
                    Mmessage.Add(message);
                    Console.WriteLine("Type next if you want to next");
                    string next = Console.ReadLine();
                    if (next == "next" || next == "Next")
                    {
                        Console.WriteLine("-------------------------------------------------");
                        Console.WriteLine("|                Pay Bills                       |");
                        Console.WriteLine("-------------------------------------------------");
                        Console.WriteLine("                Manila Water                      ");
                        Console.WriteLine("                Confirmation                     ");
                        Console.WriteLine("-------------------------------------------------");
                        Console.WriteLine("             You're about to pay                 ");
                        balance = balance - bills;
                        Console.WriteLine("               PHP " + bills + "                  ");
                        Console.WriteLine("Customer Account Number              " + can);
                        Console.WriteLine("Please note that several billers change a service fee.");
                        Console.WriteLine("Type Pay if you want to continue");
                        string pay = Console.ReadLine();
                        if (pay == "pay" || pay == "Pay")
                        {
                            Console.WriteLine("-------------------------------------------------");
                            Console.WriteLine("|                Pay Bills                       |");
                            Console.WriteLine("-------------------------------------------------");
                            Console.WriteLine("               Payment recieve for               ");
                            Console.WriteLine("                  CONVERGE ICT                  ");
                            Console.WriteLine("                 the amount of                    ");
                            Console.WriteLine("                  php " + bills + "                ");
                            Console.WriteLine("                     GCash                        ");
                            Console.WriteLine("-------------------------------------------------");
                            Console.WriteLine("                    Details                       ");
                            Console.WriteLine("Amount Paid              " + bills);
                            Console.WriteLine("Fee                      php 0.00");
                            Console.WriteLine("Account Number           " + can);
                            Console.WriteLine("This has been processed and your payment will be ");
                            Console.WriteLine("             posted within 24 hours              ");
                            Console.WriteLine("-------------------------------------------------");
                            Console.WriteLine("|                    Done                       |");
                            Console.WriteLine("-------------------------------------------------");
                            MyBayarin();
                        }
                        else
                        {
                            MyBayarin();
                        }
                    }
                }
            }
            static void End()
            {
                Console.WriteLine("Thank you for using GCASH ^^");
            }
        }
    }
}

    
