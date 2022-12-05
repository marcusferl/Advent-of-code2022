using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.IO;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;

namespace Kalender
{
    internal class day1
    {
        static public void read()
        {
            string file = "../../../Kalender/files/day1.txt";
            string text = File.ReadAllText(file);
            string[] lines = text.Split(
            new string[] { Environment.NewLine },
            StringSplitOptions.None);
            List<int> count = new List<int>();
            int counter = 0;
            foreach (string line in lines)
            {
                
                if(line.Length != 0)
                {
                    counter += Convert.ToInt32(line);
                }
                else
                {
                    count.Add(counter);
                    counter = 0;
                }
            }
            count.Sort();
            foreach(int number in count)
            {
                // Console.WriteLine($"{number}");
            }

            counter = 0;
            count.Reverse();
            for (int i = 0; i < 3; i++)
            {
                counter += count[i];
            }

            Console.WriteLine(counter);
            }

          
        }

    }

