using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Kalender
{
    internal class day6
    {

        static public void day6_part1()
        {
            string file = "../../../Kalender/files/day6.txt";
            string text = File.ReadAllText(file);
            

            int i = 0;
            int countAll = 0;
            List<char> fourBlockList;
            
                while (i < text.Length - 3)
                {
                    // Every i char, it creates a block with i + the next 3 chars
                    fourBlockList = new List<char>();
                    for (int j = i; j < i + 4; j++)
                    {
                        //Console.WriteLine(line[j]);
                        fourBlockList.Add(text[j]);
                    }
                    //Console.WriteLine("---------");
                    if (!letterCheck(fourBlockList))
                    {
                        countAll = i + 4;
                        break;
                    }
                    i++;
                }
                Console.WriteLine(countAll);
            }
        static public void day6_part2()
        {
            string file = "../../../Kalender/files/day6.txt";
            string text = File.ReadAllText(file);


            int i = 0;
            int countAll = 0;
            List<char> fourBlockList;

            while (i < text.Length - 13)
            {

                fourBlockList = new List<char>();
                for (int j = i; j < i + 14; j++)
                {
                    //Console.WriteLine(line[j]);
                    fourBlockList.Add(text[j]);
                }
                //Console.WriteLine("---------");
                if (!letterCheck(fourBlockList))
                {
                    countAll = i + 14;
                    break;
                }
                i++;
            }
            Console.WriteLine(countAll);
        }
        // Simple check if a letter more than one time in a list
        static public bool letterCheck(List<char> chars)
        {
            bool charCheck = false;
            
            foreach(char c in chars)
            {
                int counter = 0;
                for (int i = 0; i < chars.Count(); i++)
                {
                    if(c == chars[i])
                    {
                        counter ++;
                    }
                    if(counter > 1)
                    {
                        charCheck = true;
                        break;
                    }
                }
            }
            return charCheck;
        }
    }
}
