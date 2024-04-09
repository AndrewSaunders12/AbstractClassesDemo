using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Schema;

namespace ConsoleUI
{
    internal abstract class Vehicle
    {
        public int Year { get; set; } = 0;
        public string Make { get; set; } = "Default";

        public string Model { get; set; } = "Defualt";


        public abstract void DriveAbstract();

        public virtual void DriveVirtual()
        {
            Console.WriteLine("Default virtual drive method");
        }
    }
}
