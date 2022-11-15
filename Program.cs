using System;

namespace _07._Hotel_Room
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string month = Console.ReadLine();
            int nightsCount = int.Parse(Console.ReadLine());

            double studioPrice, apartmentPrice;

            switch (month)
            {
                case "May":
                case "October":
                    studioPrice = 50;
                    apartmentPrice = 65;
                    break;
                case "June":
                case "September":
                    studioPrice = 75.20;
                    apartmentPrice = 68.70;
                    break;
                case "July":
                case "August":
                default:
                    studioPrice = 76;
                    apartmentPrice = 77;
                    break;
                       
            }
            double studioCost = nightsCount * studioPrice;
            double apartmentCost = nightsCount * apartmentPrice;

            if (nightsCount > 7 && nightsCount <= 14)
            {
                if (month == "May" || month == "October")
                {
                    studioCost *= 0.95;
                }
            }
            else if (nightsCount > 14)
            {
                if (month == "May" || month == "October")
                {
                    studioCost *= 0.7;
                }
                else if (month == "June" || month == "September")
                {
                    studioCost *= 0.8;
                }
                apartmentCost *= 0.9;
            }
            Console.WriteLine($"Apartment: {apartmentCost:f2} lv.");
            Console.WriteLine($"Studio: {studioCost:f2} lv.");
        }
    }
}
