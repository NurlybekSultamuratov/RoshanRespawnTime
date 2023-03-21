using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RoshanRespawnTime
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Get the time of Roshan's death as minutes and seconds
            Console.Write("Enter the time of Roshan's death (MM:SS): ");
            string deathTimeInput = Console.ReadLine();

            // Parse the death time input string into a TimeSpan object
            TimeSpan deathTime;
            if (deathTimeInput.Contains(":"))
            {
                string[] timeParts = deathTimeInput.Split(':');
                int minutes = int.Parse(timeParts[0]);
                int seconds = int.Parse(timeParts[1]);
                if (minutes >= 60)
                {
                    int hours = minutes / 60;
                    minutes %= 60;
                    deathTime = new TimeSpan(hours, minutes, seconds);
                }
                else
                {
                    deathTime = new TimeSpan(0, minutes, seconds);
                }
            }
            else
            {
                int seconds = int.Parse(deathTimeInput);
                deathTime = new TimeSpan(0, 0, seconds);
            }

            // Calculate the Roshan respawn times
            TimeSpan respawnTime1 = deathTime.Add(TimeSpan.FromMinutes(8).Add(TimeSpan.FromSeconds(11)));
            TimeSpan respawnTime2 = deathTime.Add(TimeSpan.FromMinutes(11));

            // Output the Roshan respawn times in minutes and seconds only
            Console.WriteLine("Roshan respawn time 1: " + respawnTime1.ToString(@"hh\:mm\:ss"));
            Console.WriteLine("Roshan respawn time 2: " + respawnTime2.ToString(@"hh\:mm\:ss"));
            Console.ReadKey();
        }
    }
}
