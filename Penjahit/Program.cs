using Penjahit.Models;
using System;

namespace Penjahit
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("\n===Penjahit Celana Panjang===");
            Console.WriteLine("\nPilih Model dan Warna"); 
            Console.WriteLine("11 Cargo Hitam \n12 Cargo Putih \n13 Cargo Hijau");  
            Console.WriteLine("14 Cargo Biru \n15 Cargo merah \n21 Jeans Hitam"); 
            Console.WriteLine("22 Jeans Biru \n31 Chino Hitam \n32 Chino Putih");  
            Console.WriteLine("33 Chino Hijau \n34 Chino Biru \n35 Chino Merah");  
            
            Console.WriteLine("\n===Pilih Model==="); 
            string c = Console.ReadLine();

            if (c == "11")
            {
            CCargo cargo1 = new CCargo();
            cargo1.AddTopping(new WHitam());
            Console.WriteLine(cargo1.About());
            }

            else if(c == "12")
            {
            CCargo cargo1 = new CCargo();
            cargo1.AddTopping(new WPutih());
            Console.WriteLine(cargo1.About());
            }

            else if(c == "13")
            {
            CCargo cargo1 = new CCargo();
            cargo1.AddTopping(new WHijau());
            Console.WriteLine(cargo1.About());
            }

            else if(c == "14")
            {
            CCargo cargo1 = new CCargo();
            cargo1.AddTopping(new WBiru());
            Console.WriteLine(cargo1.About());
            }

            else if(c == "15")
            {
            CCargo cargo1 = new CCargo();
            cargo1.AddTopping(new WMerah());
            Console.WriteLine(cargo1.About());
            }

            else if (c == "21")
            {
            CJeans jeans1 = new CJeans();
            jeans1.AddTopping(new WHitam());
            Console.WriteLine(jeans1.About());
            }

            else if (c == "22")
            {
            CJeans jeans1 = new CJeans();
            jeans1.AddTopping(new WBiru());
            Console.WriteLine(jeans1.About());
            }

            else if (c == "31")
            {
            CChino chino1 = new CChino();
            chino1.AddTopping(new WHitam());
            Console.WriteLine(chino1.About());
            }

            else if (c == "32")
            {
            CChino chino1 = new CChino();
            chino1.AddTopping(new WPutih());
            Console.WriteLine(chino1.About());
            }

            else if (c == "33")
            {
            CChino chino1 = new CChino();
            chino1.AddTopping(new WHijau());
            Console.WriteLine(chino1.About());
            }

            else if (c == "34")
            {
            CChino chino1 = new CChino();
            chino1.AddTopping(new WBiru());
            Console.WriteLine(chino1.About());
            }

            else if (c == "35")
            {
            CChino chino1 = new CChino();
            chino1.AddTopping(new WMerah());
            Console.WriteLine(chino1.About());
            }

            Console.ReadKey();
        }
    }
}