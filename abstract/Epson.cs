﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace abstrak
{
    public class Epson : Printer
    {

        public override void Print()
        {
            Console.WriteLine("Merk Printer : {0}", Merk);
            Console.WriteLine("Menampilkan : {0}", Show);

            Console.WriteLine("Epson printer printing.......");
        }
    }
}