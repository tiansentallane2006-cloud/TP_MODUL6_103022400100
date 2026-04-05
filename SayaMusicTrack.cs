using System;
using System.Diagnostics;
namespace TP_MODUL6_103022400100

{
    public class SayaMusicTrack
    {
        private int id;
        private string title;
        private int playCount;

        public SayaMusicTrack(string title)
        {
            Debug.Assert(title != null);
            Debug.Assert(title.Length <= 100);

            this.title = title;
            Random random = new Random();
            this.id = random.Next(10000, 100000);
            this.playCount = 0;
        }

        public void IncreasePlayCount(int count)
        {
            Debug.Assert(count <= 10000000);

            try
            {
                checked
                {
                    this.playCount += count;
                }
            }
            catch (OverflowException ex)
            {
                Console.WriteLine("Error: " + ex.Message);
            }
        }

        public void PrintTrackDetails()
        {
            Console.WriteLine("--- Track Details ---");
            Console.WriteLine("ID         : " + id);
            Console.WriteLine("Title      : " + title);
            Console.WriteLine("Play Count : " + playCount);
            Console.WriteLine("----------------------");
        }
    }
}