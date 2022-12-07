using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Kalender
{
    internal class day4
    {
        static string file = "../../../Kalender/files/day4.txt";
        static string[] lines = File.ReadAllLines(file);

        static string firstsplit = "";
        static string secondsplit = "";

        static int left_min;
        static int left_max;
        static int right_min;
        static int right_max;

        static int counter = 0;
        
        static public void day4_part1()
        {
           
            foreach (string line in lines)
            {
                var firstsplit_ = line.Split(',');
                firstsplit = firstsplit_[0];
                secondsplit = firstsplit_[1];
                var left = firstsplit.Split('-');
                var right = secondsplit.Split('-');

                left_min = Convert.ToInt16(left[0]);
                left_max = Convert.ToInt16(left[1]);
                right_min = Convert.ToInt16(right[0]);
                right_max = Convert.ToInt16(right[1]);
                
                if((left_min >= right_min && left_max <= right_max)||(right_min >= left_min && right_max <= left_max))
                {
                    counter += 1;
                    
                }
            }
            Console.WriteLine($"Part1 {counter}");
        }

        static public void day4_part2()
        {

            foreach (string line in lines)
            {
                var firstsplit_ = line.Split(',');
                firstsplit = firstsplit_[0];
                secondsplit = firstsplit_[1];
                var left = firstsplit.Split('-');
                var right = secondsplit.Split('-');

                left_min = Convert.ToInt16(left[0]);
                left_max = Convert.ToInt16(left[1]);
                right_min = Convert.ToInt16(right[0]);
                right_max = Convert.ToInt16(right[1]);

                if ((left_min >= right_min && left_min<=right_max) || (left_max > right_min && left_max <= right_max) || (right_min >= left_min && right_min <= left_max) || (right_max > left_min && right_max <= left_max))
                {
                    counter += 1;
                    continue;
                }
            }
            Console.WriteLine($"Part1 {counter}");
        }


    }
}
