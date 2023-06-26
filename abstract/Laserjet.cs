using System;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace abstrak
{
    public class Laserjet : Printer
    {

        public override void Print()
        {
            Console.WriteLine("Merk Printer : {0}", Merk);
            Console.WriteLine("Menampilkan : {0}", Show);

            Console.WriteLine("LaserJet printer printing.......");
        }
    }
}