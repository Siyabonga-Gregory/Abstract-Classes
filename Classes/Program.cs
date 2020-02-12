using System;

namespace AbstractClasses
{
 
    class Program
    {
       public static void Main(string[]args)
        {
            Tazz tazz = new Tazz() { 
                make = "Toyota",
                model = "Tazz", 
                variation = "1.6 4 doors",
                dateRelease = DateTime.Now,
                price = 90000.00 
            };

            Console.WriteLine(tazz.GetBasicDetails());
            Console.WriteLine(tazz.GetTrackingDetails());
            Console.WriteLine("---------------------------------------------");

            Avanza avanza = new Avanza() {
                make = "Toyota",
                model = "Avanza",
                variation = "1.6 4 doors",
                dateRelease = DateTime.Now,
                price = 90000.00,
                isTrackerInstalled=true,
                trackingCompany="NOJACK"
            };

            Console.WriteLine(avanza.GetBasicDetails());
            Console.WriteLine(avanza.GetTrackingDetails());
            Console.WriteLine("---------------------------------------------");

            Yaris yaris = new Yaris()
            {
                make = "Toyota",
                model = "Yaris",
                variation = "1.8 3 doors",
                dateRelease = DateTime.Now,
                price = 190000.00,
                isTrackerInstalled = true,
                trackingCompany = "NOJACK"
            };

            Console.WriteLine(yaris.GetBasicDetails());
            Console.WriteLine(yaris.GetTrackingDetails());
            Console.ReadLine();
        }
    }
}
