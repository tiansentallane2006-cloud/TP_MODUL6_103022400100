using System;

namespace TP_MODUL6_103022400100
{
    class Program
    {
        static void Main(string[] args)
        {
            SayaMusicTrack lagu = new SayaMusicTrack("Sample Track Title");
            lagu.PrintTrackDetails();

            lagu.IncreasePlayCount(5000);
            lagu.PrintTrackDetails();

            Console.WriteLine("\n--- Testing Overflow ---");
            for (int i = 0; i < 220; i++)
            {
                lagu.IncreasePlayCount(10000000);
            }

            lagu.PrintTrackDetails();
        }
    }
}