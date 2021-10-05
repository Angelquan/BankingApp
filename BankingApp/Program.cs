using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Console;


namespace BankingApp
{
    class Program
    {
        static void Main(string[] args)
        {
            int a;
            double total = 0;
            string inputString = "y";

            while (inputString == "y" || inputString == "Y")
            {
                welcomeLine();
                a = Convert.ToInt32(ReadLine());
                if (a == 1)
                {
                    total += deposit();
                    WriteLine();
                }
                else if (a == 2)
                {
                    total += withdrawl();
                    WriteLine();
                }
                else if (a == 3)
                {
                    checkbal();
                    WriteLine();
                }
                else
                {
                    WriteLine("please enter\n 1-Deposit\n 2-Withdrawl\n 3-Check Balance ");
                    WriteLine();
                }

                thankYou();
                inputString = ReadLine();
            }
   

            ReadKey();
        } //closes main

        static void welcomeLine()
        {
            WriteLine($"Your current balance is $1000.00 Would you like to:\n 1-Deposit\n 2-Withdrawl\n 3-Check Balance");
        }

        static double deposit()
        {
            Double x, y;
            WriteLine("How much would would you like to deposit?");
            x = Convert.ToDouble(ReadLine());
            y = x + 1000;
            WriteLine($"your new balance is {y.ToString("C")}");
            return y;
        }

        static double withdrawl()
        {
            Double b, c;
            WriteLine("How much would you like to withdraw today?");
            b = Convert.ToDouble(ReadLine());
            c = 1000 - b;
            WriteLine($" Your balance is {c.ToString("C")}");
            return c;

        }
        static void checkbal()
        {
            int c = 1000;
            WriteLine($"your balance is {c.ToString("C")}");
        }

        static void thankYou()
        {
            WriteLine("Would you like to make another transaction?\n y-yes\n n-no");

        }
    }
}



    
    
