using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ReadingLevelFile
{
    class Program
    {
        static void Main(string[] args)
        {
            //Verander de naam van de consolebox
            Console.Title = "Level";

            // Maak een object van de Level class
            Level level;
            level = new Level();

            //Laat het consolescherm wachten op een toetsaanslag
            Console.ReadLine();
        }
    }
}
