using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Kalender
{
    /*A = Stein, B = Papier, C = Schere
      X = Stein, Y = Papier, Z = Schere
      Stein = 1, Papier = 2, Schere = 3
      3 Unentschieden, 6 Sieg*/
    internal class day2
    {
        static int counter = 0;
        static string[] lines;
        static public void day_2_einlesen()
        {
            string file = "../../../Kalender/files/day2.txt";
            string text = File.ReadAllText(file);
            lines = text.Split(
            new string[] { Environment.NewLine },
            StringSplitOptions.None);
        }

        static public void day2_partOne()
        {
            day_2_einlesen();
            foreach (string line in lines)
            {
                string ausgang = "";

                if (line[0] == 'A' && line[2] == 'X')
                {
                    ausgang = "unentschieden";

                }
                else if (line[0] == 'A' && line[2] == 'Y')
                {
                    ausgang = "gewonnen";
                }
                else if (line[0] == 'A' && line[2] == 'Z')
                {
                    ausgang = "verloren";
                }
                else if (line[0] == 'B' && line[2] == 'X')
                {
                    ausgang = "verloren";
                }
                else if (line[0] == 'B' && line[2] == 'Y')
                {
                    ausgang = "unentschieden";
                }
                else if (line[0] == 'B' && line[2] == 'Z')
                {
                    ausgang = "gewonnen";
                }
                else if (line[0] == 'C' && line[2] == 'X')
                {
                    ausgang = "gewonnen";
                }
                else if (line[0] == 'C' && line[2] == 'Y')
                {
                    ausgang = "verloren";
                }
                else if (line[0] == 'C' && line[2] == 'Z')
                {
                    ausgang = "unentschieden";
                }

                counter_(ausgang, line[2]);
            }
            Console.WriteLine($"Endergebnis: {counter}");
        }
        static private void counter_(string ausgang, char buchstabe)
        {
            switch (ausgang)
            {
                case "gewonnen":
                    counter += 6;
                    break;
                case "verloren":
                    counter += 0;
                    break;
                case "unentschieden":
                    counter += 3;
                    break;
            }

            switch (buchstabe)
            {
                case 'X':
                    counter += 1;
                    break;
                case 'Y':
                    counter += 2;
                    break;
                case 'Z':
                    counter += 3;
                    break;
            }
        }
        static public void day2_partTwo()
        {
            day_2_einlesen();
            
            foreach (string line in lines)
            {
                string ausgang = "";
                if (line[0] == 'A' && line[2] == 'X')
                {
                    ausgang = "schere";

                }
                else if (line[0] == 'A' && line[2] == 'Y')
                {
                    ausgang = "stein";
                }
                else if (line[0] == 'A' && line[2] == 'Z')
                {
                    ausgang = "papier";
                }
                else if (line[0] == 'B' && line[2] == 'X')
                {
                    ausgang = "stein";
                }
                else if (line[0] == 'B' && line[2] == 'Y')
                {
                    ausgang = "papier";
                }
                else if (line[0] == 'B' && line[2] == 'Z')
                {
                    ausgang = "schere";
                }
                else if (line[0] == 'C' && line[2] == 'X')
                {
                    ausgang = "papier";
                }
                else if (line[0] == 'C' && line[2] == 'Y')
                {
                    ausgang = "schere";
                }
                else if (line[0] == 'C' && line[2] == 'Z')
                {
                    ausgang = "stein";
                }
                counter_part_two(ausgang, line[2]);
            }
            Console.WriteLine($"Endergebnis: {counter}");
        }
        static private void counter_part_two(string ausgang, char buchstabe)
        {
            switch (ausgang)
            {
                case "stein":
                    counter += 1;
                    break;
                case "papier":
                    counter += 2;
                    break;
                case "schere":
                    counter += 3;
                    break;
            }

            switch (buchstabe)
            {
                case 'X':
                    counter += 0;
                    break;
                case 'Y':
                    counter += 3;
                    break;
                case 'Z':
                    counter += 6;
                    break;
            }
        }
    }
}
