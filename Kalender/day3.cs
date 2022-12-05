using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Diagnostics.CodeAnalysis;
using System.IO;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace Kalender
{
    internal class day3
    {
        static string file = "../../../Kalender/files/day3.txt";
        static string letters = "0abcdefghijklmnopqrstuvwxyzABCDEFGHIJKLMNOPQRSTUVWXYZ";
        static string[] lines = File.ReadAllLines(file);
        static List<string> bag1 = new List<string>();
        static List<string> bag2 = new List<string>();
        static int sum = 0;

        public static void day3_part1()
        {
            Console.WriteLine(letters.Count());
            

            foreach (string line in lines)
            {
                bag1.Add(line.Substring(0, (line.Length / 2)));
                bag2.Add(line.Substring(line.Length / 2));
            }

            for(int i = 0; i < bag1.Count; i++)
            {
               foreach(char c in bag1[i])
                {
              
                    if (bag2[i].Contains(c))
                    {
                        for(int j = 0; j < letters.Count(); j++)
                        {
                            if(letters[j] == c)
                            {
                                sum += j;
                            }
                        }
                        Console.WriteLine(c);
                        break;
                    }
                    
                }
            }
            Console.WriteLine(sum);
        }
        public static void day3_part2()
        {
            int counter = 0;
            int start = 0;
            char bla = ' ';

            while (counter < lines.Count())
            {
                
                    foreach(char c in lines[start])
                    {
                        if (lines[start].Contains(c) && lines[start+1].Contains(c) && lines[start + 2].Contains(c))
                    {
                        bla = c;
                        break;
                    }
                    }
                for (int j = 0; j < letters.Count(); j++)
                {
                    if (letters[j] == bla)
                    {
                        sum += j;
                    }
                }

                Console.WriteLine(sum);
                start += 3;
                counter +=3;
                
            }

            }
        }
    }


