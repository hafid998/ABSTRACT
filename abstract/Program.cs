using System;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace abstrak
{
    class Program
    {
        static void Main(string[] args)
        {
            Printer epson = new Epson();
            Printer canon = new Canon();
            Printer laserjet = new Laserjet();

            epson.Merk = "Epson\n";
            epson.Show = "Epson display dimension : 10*11\n";

            canon.Merk = "Canon\n";
            canon.Show = "Canon display dimension : 9,5*12\n";

            laserjet.Merk = "LaserJet\n";
            laserjet.Show = "LaserJet display dimension : 11*12\n";

            Console.WriteLine("Silahkan Pilih Printer Berikut : ");
            Console.WriteLine("1. Epson");
            Console.WriteLine("2. Canon");
            Console.WriteLine("3. LaserJet");

            Console.Write("Silahkan pilih jenis Printer [1...3] : ");
            int pilih = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("=============================================");

            if (pilih == 1)
                epson.Print();
            else if (pilih == 2)
                canon.Print();
            else if (pilih == 3)
                laserjet.Print();
            else
                Console.WriteLine("Maaf printer yang anda pilih {0} tidak ada!!", pilih);

            Console.ReadLine();
            return;

        }
    }
}