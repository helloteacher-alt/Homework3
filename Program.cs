using System;

namespace ComeproHomework3
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Time or price(lowercase letter):");
            string timeprice = Console.ReadLine();
            Console.Write("Input x position:");
            double xT = double.Parse(Console.ReadLine());
            Console.Write("Input y position:");
            double yP = double.Parse(Console.ReadLine());

            
            if (timeprice == "time"||timeprice=="price")
             {
                 if (xT <= 0)
                {
                    Console.WriteLine("Invalid mouse position.");
                }
                else if (timeprice == "time")
                {
                    yP = Math.Pow(xT - 1, 2);
                    Console.WriteLine("{0},{1}", xT, yP);

                }
                else if (timeprice == "price")
                {
                    xT = Math.Sqrt(yP);
                    xT = xT + 1;
                    Console.WriteLine("{0},{1}", xT, yP);
                }
            }
            else { Console.WriteLine("Invalid mode.");}
            


        }
    }
}
