using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Globalization;
using System.IO;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Markup;
using System.Xml.Schema;

namespace Kalender
{
    internal class day8_01
    {
        static string file = "../../../Kalender/files/day8.txt";
        static string[] lines = File.ReadAllLines(file);



        static public void day8_part1()
        {
            int counter = 0;
            for (int i = 0; i < lines.Length; i++)
            {
                for (int j = 0; j < lines[i].Length; j++)
                {
                    if (visibleCheck(lines[i], j))
                    {
                        counter++;
                    }
                    else if (visibleCheck(columnString(j), i))
                    {
                        counter++;

                    }
                }
            }
            Console.WriteLine(counter);
        }

        public static string columnString(int column)
        {
            StringBuilder columnString = new StringBuilder();
            for (int i = 0; i < lines.Length; i++)
            {
                columnString.Append(lines[i][column]);
            }
            return columnString.ToString();
        }

        static public bool visibleCheck(string seq, int current_index)
        {
            bool visible_right = true;
            bool visible_left = true;
            for (int i = 0; i < seq.Length; i++)
            {
                if (i < current_index)
                {
                    if (seq[i] < seq[current_index])
                    {
                        visible_right = true;
                    }
                    else
                    {
                        visible_right = false;
                        break;
                    }
                }
            }
            for (int i = 0; i < seq.Length; i++)
            {
                if (i > current_index)
                {
                    if (seq[i] < seq[current_index])
                    {
                        visible_left = true;
                    }
                    else
                    {
                        visible_left = false;
                        break;
                    }
                }
            }
            if (visible_right || visible_left)
            {
                return true;
            }
            return false;
        }
    }
    class day8_02
    {
        static string file = "../../../Kalender/files/day8.txt";
        static string[] lines = File.ReadAllLines(file);

        static public void day8_part2()
        {
            int bestTreeCounter = 0;
            int counter = 0;

            for (int i = 0; i < lines.Length; i++)
            {
                for (int j = 0; j < lines[i].Length; j++)
                {
                    counter += placeLeftSite(lines[i], j);
                    counter *= placeRightSite(lines[i], j);
                    counter *= placeTopSite(columnString(j), i);
                    counter *= placeBottomSite(columnString(j), i);

                    if(bestTreeCounter < counter)
                    {
                        bestTreeCounter = counter;
                    }
                    counter = 0;
                }
            }
            Console.WriteLine(bestTreeCounter);
        }
    
        public static string columnString(int column)
        {
            StringBuilder columnString = new StringBuilder();
            for (int i = 0; i < lines.Length; i++)
            {
                columnString.Append(lines[i][column]);
            }
            return columnString.ToString();
        }

        static public int placeLeftSite(string seq, int current_index)
        {
            int counter = 0;

            for (int i = current_index-1; i >= 0; i--)
            {
                if (seq[i] < seq[current_index])
                {
                    counter++;
                }
                else if(seq[i] >= seq[current_index])
                {
                    counter++;
                    break;
                }
                else
                {
                    break;
                }
            }
            
            return counter;
        }
        static public int placeRightSite(string seq, int current_index)
        {
            int counter = 0;

            if(current_index < seq.Length)
            {
                for (int i = current_index + 1; i < seq.Length; i++)
                {
                    if (seq[i] < seq[current_index])
                    {
                        counter++;
                    }
                    else if (seq[i] >= seq[current_index])
                    {
                        counter++;
                        break;
                    }
                    else
                    {
                        break;
                    }
                }
            }
            
          
            return counter;
        }
        static public int placeTopSite(string seq, int current_index)
        {
            int counter = 0;

            for (int i = current_index - 1; i >= 0; i--)
            {
                if (seq[i] < seq[current_index])
                {
                    counter++;
                }
                else if (seq[i] >= seq[current_index])
                {
                    counter++;
                    break;
                }
                else
                {
                    break;
                }
            }
            return counter;
        }
        static public int placeBottomSite(string seq, int current_index)
        {
            int counter = 0;

            for (int i = current_index + 1; i < seq.Length; i++)
            {
                if (seq[i] < seq[current_index])
                {
                    counter++;
                }
                else if (seq[i] >= seq[current_index])
                {
                    counter++;
                    break;
                }
                else
                {
                    break;
                }
            }
            return counter;
        }

    }
}
