using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.IO;

namespace ReadingLevelFile
{
    public class Level
    {
        //Fields
        //private string[] levelText = new string[20];

        private List<string> stringList = new List<string>();

        private List<string> zeroToOneAndOneToZero = new List<string>();

        //Properties


        //Constructor
        public Level()
        {
            //this.ReadLevelFromText();
            //this.CountNumberOneAndZero();
            this.ChangeOneToZeroAndZeroToOne();
            
        }


        //Methods
        private void ReadLevelFromText()
        {
            FileStream fileStream = File.OpenRead(@"C:\Users\Arjan de Ruijter\Documents\Visual Studio 2010\Projects\2014-2015\22-writing_and_reading_from_files\ReadingLevelFile\level-0.txt");

            TextReader reader = new StreamReader(fileStream);

            //Vul het array levelText en schrijf ook de inhoud naar de console
            string line = reader.ReadLine();
            
            /*
            int i = 0;
            while (line != null)
            {
                this.levelText[i] = line;
                line = reader.ReadLine();
                i++;
            }

            foreach (string lineInFile in this.levelText)
            {
                Console.WriteLine(lineInFile);
            }
            */

            while (line != null)
            {
                this.stringList.Add(line);
                line = reader.ReadLine();
            }

            foreach (string lineInFile in this.stringList)
            {
                Console.WriteLine(lineInFile);
            }

            Console.WriteLine("Er zijn {0} regels text in de List: stringList", this.stringList.Count);
            
            fileStream.Close();
            reader.Close();
        }

        private void CountNumberOneAndZero()
        {
            int numberOnes = 0;
            int numberZeros = 0;
            
            foreach (string lineInList in this.stringList)
            {
                for (int i = 0; i < lineInList.Length; i++)
                {
                    if (lineInList[i] == '1')
                    {
                        numberOnes++;
                    }
                    else if (lineInList[i] == '0')
                    {
                        numberZeros++;
                    }
                    else {}
                }
            }

            Console.WriteLine("Het aantal enen bedraagt: {0} en het aantal nullen bedraagt {1}",
                                numberOnes, numberZeros);
        }

        private void ChangeOneToZeroAndZeroToOne()
        {
            FileStream fileStream = File.OpenRead(@"C:\Users\Arjan de Ruijter\Documents\Visual Studio 2010\Projects\2014-2015\22-writing_and_reading_from_files\ReadingLevelFile\toets.txt");

            TextReader textReader = new StreamReader(fileStream);

            string line = textReader.ReadLine();

            while (line != null)
            {
                this.zeroToOneAndOneToZero.Add(line);
                line = textReader.ReadLine();
            }
            
            foreach (string stringLine in this.zeroToOneAndOneToZero)
            {
                string stringTemp = "";
                foreach (char number in stringLine)
                {
                    if (number == '0')
                    {
                        stringTemp += '1';
                    }
                    else if (number == '1')
                    {
                        stringTemp += '0';
                    }
                }
                Console.WriteLine(stringTemp);
            }
            
            /*
            string testString = "Arjan de Ruijter"; // Een string is een array die char's bevat

            foreach (char letter in testString)
            {
                Console.WriteLine(letter);
            }
            */
        }        
    }
}
