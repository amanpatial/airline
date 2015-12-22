using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Airline
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Airline Boarding System");
            
            var plane = new Aeroplane();

            // Keep the console window open in debug mode.
            Console.WriteLine("Press any number of passenger");
            //Console.ReadKey();
            
            string userInput = Console.ReadLine();
            int passengerCount = Convert.ToInt32(userInput);

            while (passengerCount > 0)
            {
                if (plane.CheckSeatAvailablity(passengerCount))
                {
                    List<Seat> lsts = plane.reserveSeat(passengerCount);
                    lsts.ForEach(Console.WriteLine);
                }
                else
                {
                    Console.WriteLine("Seat(s) number are less than pasenger number(s)");
                }

                Console.WriteLine("Press any number of passenger");
                //Console.ReadKey();

                userInput = Console.ReadLine();
                passengerCount = Convert.ToInt32(userInput);

            }          
        }
    }
}
