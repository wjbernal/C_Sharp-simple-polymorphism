using System;

namespace cs_simple_polymorphism
{
    class Program
    {
        public static void Main(string[] args)
        {
            Stock msft = new Stock {
                Name = "MSFT",
                SharesOwned = 1000
            };

            House mansion = new House {
                Name = "Mansion",
                Mortgage = 20000.54
            };

            System.Console.WriteLine(msft.Name);
            System.Console.WriteLine(msft.SharesOwned);
            System.Console.WriteLine(mansion.Name);
            System.Console.WriteLine(mansion.Mortgage);
            
            DisplayAsset(msft);
            DisplayAsset(mansion);

            //Upcasting
            Asset a = msft;  // always succeds.
            Console.WriteLine ("Upcasting Stock to Asset: {0}", a.Name);  // will be OK
            //    Console.WriteLine (a.SharesOwned);     will give a Compile-time error
            //                                           because type Asset does not know SharesOwned.

            //Downcasting
            Stock s = (Stock) a;       // Downcast requires a suitable typed. 
            Console.WriteLine ("Upcasting Stock to Asset: {0}", s.SharesOwned);    // no error
            
            //If a downcast fails, an InvalidCastException is thrown

            //***** AS OPERATOR ***//

            Asset b = new Asset();
            Stock st = b as Stock;  // st is null; No exception thrown
            if (st == null)
            {
                Console.WriteLine("st is a null object! ");
            }

            //----- IS OPERATOR ----//
            if(st is Stock)
            {
                Console.WriteLine("Even Though, st is a Stock Type");
            }
            else
            {
                Console.WriteLine("Even Though, st is NOT a Stock Type");
            }


            






        }

        //Polymorphism
        public static void DisplayAsset(Asset asset)
        {
            System.Console.WriteLine("Asset name {0}", asset.Name);            
        }
    }
}
