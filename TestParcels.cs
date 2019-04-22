// Program 1B
// CIS 200-01
// Fall 2018
// Due: 10/3/2018
// By: Grading ID3100

//This program is using LINQ to create a simple list of reports. We created different test address and packages

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Prog1
{
    class TestParcels
    {
        // Precondition:  None
        // Postcondition: Parcels have been created and displayed
        static void Main(string[] args)
        {
            // Test Data - Magic Numbers OK
            Address a1 = new Address("  John Smith  ", "   123 Any St.   ", "  Apt. 45 ",
                "  Louisville   ", "  KY   ", 40202); // Test Address 1
            Address a2 = new Address("Jane Doe", "987 Main St.",
                "Beverly Hills", "CA", 90210); // Test Address 2
            Address a3 = new Address("James Kirk", "654 Roddenberry Way", "Suite 321",
                "El Paso", "TX", 79901); // Test Address 3
            Address a4 = new Address("John Crichton", "678 Pau Place", "Apt. 7",
                "Portland", "ME", 04101); // Test Address 4
            Address a5 = new Address("Michael Joseph", "424 bradley Place", "Suite 534",
                "New York", "NY", 25958); // Test Address 5
            Address a6 = new Address("Bradley Pitt", "479 Valley Station", "Apt. 9",
                "Portland", "OR", 89581); // Test Address 6
            Address a7 = new Address("Jennifer Hiesman", "199 Montary Way", "Suite 102",
                " Los Angeles", "CA", 57553); // Test Address 7
            Address a8 = new Address("Michael Perry", "323 Kareem Ave", "Apt. 62",
                "Lexington", "KY", 64756); // Test Address 8

            //Addded additional test data to the list
            Letter letter1 = new Letter(a1, a2, 3.95M);   // Letter test object
            Letter letter2 = new Letter(a8, a4, 2.75M)  ;// Letter test object
            Letter letter3 = new Letter(a3, a7, 8.95M);  // Letter test object
            GroundPackage gp1 = new GroundPackage(a3, a4, 14, 10, 5, 12.5);        // Ground test object
            GroundPackage gp2 = new GroundPackage(a5, a2, 10, 17, 2, 15.5);        // Ground test object
            GroundPackage gp3 = new GroundPackage(a1, a6, 18, 12, 1, 14.5);        // Ground test object
            NextDayAirPackage ndap1 = new NextDayAirPackage(a1, a3, 25, 15, 15,    // Next Day test object
                85, 7.50M);
            NextDayAirPackage ndap2 = new NextDayAirPackage(a4, a5, 13, 11, 39,    // Next Day test object
                27, 5.50M);
            NextDayAirPackage ndap3 = new NextDayAirPackage(a3, a8, 32, 16, 57,    // Next Day test object
                74, 8.20M);

            TwoDayAirPackage tdap1 = new TwoDayAirPackage(a4, a1, 46.5, 39.5, 28.0, // Two Day test object
                80.5, TwoDayAirPackage.Delivery.Saver);
            TwoDayAirPackage tdap2 = new TwoDayAirPackage(a6, a4, 32.5, 56.5, 19.0, // Two Day test object
                30.5, TwoDayAirPackage.Delivery.Saver);
            TwoDayAirPackage tdap3 = new TwoDayAirPackage(a2, a8, 56.5, 95.5, 44, // Two Day test object
                59, TwoDayAirPackage.Delivery.Saver);

            List<Parcel> parcels;      // List of test parcels

            parcels = new List<Parcel>();

            
            //Populated list of additional test data
            parcels.Add(letter1); // Populate list
            parcels.Add(letter2);
            parcels.Add(letter3);
            parcels.Add(gp1);
            parcels.Add(gp2);
            parcels.Add(gp3);
            parcels.Add(ndap1);
            parcels.Add(ndap2);
            parcels.Add(tdap3);
            parcels.Add(tdap1);
            

            Console.WriteLine("Original List:");
            Console.WriteLine("====================");
            foreach (Parcel p in parcels)
            {
                Console.WriteLine(p);
                Console.WriteLine("====================");
            }
            Pause();

            //Selecting all parcels and ordering by destination zip
            var parcelsbyDestinationZip =
                from p in parcels
                orderby p.DestinationAddress.Zip descending
                select p;

            Console.WriteLine("Each parcel selected by the destination zip in descending order");

            foreach (Parcel p in parcelsbyDestinationZip)
            {
                if (parcelsbyDestinationZip.Any())

                    Console.WriteLine(p);
                else
                    Console.WriteLine(p.DestinationAddress.Zip);
            }


            //Selecting parcels by cost
            var parcelbyCost =
                from p in parcels
                orderby p.CalcCost() ascending
                select p;

            Console.WriteLine("Each parcel selected by the Cost");

            foreach (Parcel p in parcelbyCost)
            {
                if (parcelbyCost.Any())

                    Console.WriteLine(p);
                else
                    Console.WriteLine(p.CalcCost());

            }

            //Selecting parcels by get type and cost
            var parcelsbyTypeandCost =
                from p in parcels
                orderby p.GetType().ToString() ascending, p.CalcCost() descending
                select p;

            Console.WriteLine("Each parcel is selected by the get type and cost");

            foreach (Parcel p in parcelsbyTypeandCost)
            {
                if (parcelsbyTypeandCost.Any())

                    Console.WriteLine(p);
                else
                    Console.WriteLine(p.GetType().ToString(), p.CalcCost());
            }

            //Select heavy air package and ordering by descending
            var heavyweightairpackages =
                from p in parcels
                let ap = p as AirPackage
                where (ap != null) && ap.IsHeavy()
                orderby ap.Weight descending
                select ap;

            Console.WriteLine("Each Airpackage if it is heavy");

            foreach (AirPackage ap in heavyweightairpackages)
            {
                if (heavyweightairpackages.Any())

                    Console.WriteLine(ap);
                else
                    Console.WriteLine(ap.GetType().ToString(), ap.Weight);
            }
       }

        
        // Precondition:  None
        // Postcondition: Pauses program execution until user presses Enter and
        //                then clears the screen
        public static void Pause()
        {
            Console.WriteLine("Press Enter to Continue...");
            Console.ReadLine();

            Console.Clear(); // Clear screen
        }
    }
}
