using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.IO;

namespace _22_writing_and_reading_from_files
{
    class Program
    {
        static void Main(string[] args)
        {
            /* Tekst wegschrijven naar een tekstbestand 
             */
            Console.WriteLine("We gaan een tekst wegschrijven naar een bestand \n" +
                                "textIO.txt op het bureaublad");
            string textToRemember = "Dit is wat tekst die ik wil opslaan in een tekstbestand";

            File.WriteAllText(@"C:\Users\Arjan de Ruijter\Desktop\textIO.txt", textToRemember);

            Console.WriteLine("++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++");

            string[] fruit = new string[5];
            fruit[0] = "1ste regel => Aardbei";
            fruit[1] = "2de regel  => Banaan";
            fruit[2] = "3de regel  => Sinaasappel";
            fruit[3] = "4de regel  => Appel";

            Console.WriteLine("Er wordt nu informatie weggeschreven naar een file genaamd\n " +
                              "fileIO.txt. De tekst staat in een Array en elke waarde wordt\n" +
                              "op een aparte regel weggeschreven");

            File.WriteAllLines(@"C:\Users\Arjan de Ruijter\Desktop\fileIO.txt", fruit);

            string fileContents;
            fileContents = File.ReadAllText(@"C:\Users\Arjan de Ruijter\Desktop\textIO.txt");
            Console.WriteLine(fileContents);

            string[] fileContentByLine;
            fileContentByLine = File.ReadAllLines(@"C:\Users\Arjan de Ruijter\Desktop\fileIO.txt");
            foreach (string line in fileContentByLine)
            {
                Console.WriteLine(line);
            }

            Console.ReadLine();
        }
    }
}
