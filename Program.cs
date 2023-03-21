namespace Taxi
{
    class program
    {
        static void Main(string[] args)
        {
            Taxi taxi = new Taxi();

            taxi.DriverName = "Riyanto";
            taxi.onDuty = false; taxi.onDuty = true;
            taxi.numPassanger = 0881221345;


            taxi.info();
            taxi.naik();
            taxi.turun();

            Console.ReadKey();
        }
    }
}



