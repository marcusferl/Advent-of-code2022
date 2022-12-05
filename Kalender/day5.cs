using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace Kalender
{
    internal class day5
    {
        static List<List<char>> lists = new List<List<char>>();

        // Create Base lists in "lists"
        public static void createBaseList()
        {
            string file = "../../../Kalender/files/day5_base.txt";
            string[] lines = File.ReadAllLines(file);

            // 9 Columns in file day5_base
            int column = 9;

            for (int i = 0; i < column; i++)
            {
                lists.Add(new List<char>());
            }

            // If on this index a char, @ it to a specific list
            foreach (string _line in lines)
            {
                if (_line[1] != ' ')
                {
                    lists[0].Add(_line[1]);
                    
                }
                if (_line[5] != ' ')
                {
                    lists[1].Add(_line[5]);
                   
                }
                if (_line[9] != ' ')
                {
                    lists[2].Add(_line[9]);
                  
                }
                if (_line[13] != ' ')
                {
                    lists[3].Add(_line[13]);
                  
                }
                if (_line[17] != ' ')
                {
                    lists[4].Add(_line[17]);
                  
                }
                if (_line[21] != ' ')
                {
                    lists[5].Add(_line[21]);
                    
                }
                if (_line[25] != ' ')
                {
                    lists[6].Add(_line[25]);
                    
                }
                if (_line[29] != ' ')
                {
                    lists[7].Add(_line[29]);
                    
                }
                if (_line[33] != ' ')
                {
                    lists[8].Add(_line[33]);
                    
                }


            }
            
        }


        static public void getMoveLine()
        {
            createBaseList();
            string file = "../../../Kalender/files/day5.txt";
            string[] lines = File.ReadAllLines(file);
            
            
           foreach(string line in lines)
           {

           
            // Mover
            List<int> splitTheLineList = new List<int>();
            splitTheLineList = splitTheLine(line);

            int moveFrom = splitTheLineList[1] -1;
            int moveAll = splitTheLineList[0];
            int moveTo = splitTheLineList[2] -1;


                for(int i = 0; i < moveAll; i++)
                {
                char x = lists[moveFrom].ElementAt(0);
                lists[moveFrom].RemoveAt(0);
                lists[moveTo].Reverse();
                lists[moveTo].Add(x);
                lists[moveTo].Reverse();
                } 
           }
            foreach (List<char> _charList in lists)
            {
                
                Console.WriteLine(_charList[0]);
            }
        }

        // Removes the Words, and store the needed Numbers
        static List<int> splitTheLine(string line)
        {
            List<int> list = new List<int>();
            line = line.Replace("move ", "");
            line = line.Replace("from ", "");
            line = line.Replace("to ", "");

            var a =line.Split(' ');
            foreach (string i in a)
            {
                list.Add(Convert.ToInt32(i));
            }
            return list;
        }
    }

}
