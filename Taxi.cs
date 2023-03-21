using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Taxi
{
    public class Taxi
    {
        public string DriverName { get; set; }
        public Boolean onDuty { get; set; }
        public int numPassanger { get; set; }

        public void info()
        {
            Console.WriteLine("\n Taxi Info \n");
            Console.WriteLine(" Nama Driver : {0}", DriverName);

            if (onDuty == true)
            {
                Console.WriteLine(" Kerja : Iya", onDuty);
            }
            else
            {
                Console.WriteLine(" Kerja : Tidak", onDuty);
            }

            Console.WriteLine(" Nomor Pelanggan : {0}", numPassanger);

        }

        public void naik()
        {
            Console.WriteLine("\n {0} Sedang Mengantarkan Penumpang", DriverName);
        }

        public void turun()
        {
            Console.WriteLine("\n {0} Sedang Menurunkan Peumpang", DriverName);
        }
    }
}
