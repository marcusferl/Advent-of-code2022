using Microsoft.SqlServer.Server;
using System;
using System.Collections.Generic;
using System.ComponentModel.Design.Serialization;
using System.Diagnostics;
using System.Globalization;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Kalender
{
    internal class day7
    {
        static string file = "../../../Kalender/files/day7.txt";
        static string[] lines = File.ReadAllLines(file);



        static public void day7_part1()
        {
            Dictionary<string, Folder> folders = new Dictionary<string, Folder>();
            Folder root = new Folder("/", new List<string>(), 0);
            folders["/"] = root;

            string currentPath = "/";
            Folder currentFolder = root;

            foreach (string line in lines)
            {
                if (line.StartsWith("$ cd ") && !line.StartsWith("$ cd .."))
                {
                    var newFolder = line.Substring(5);
                    if (newFolder == "/")
                    {
                        currentPath = "/";
                    }
                    else
                    {
                        currentPath = newFolder;
                        folders[currentPath] = new Folder(currentPath, new List<string>(), 0);
                    }
                }
                else if (line.StartsWith("dir "))
                {
                    folders[currentPath].subFolders.Add(line.Substring(4));
                }
                else if(line.StartsWith("$ ls "))
                {
                    continue;
                }
                else
                {
                    if (!line.Contains('$'))
                    {
                        folders[currentPath].fileSize += Convert.ToInt32(line.Split(' ')[0]);
                    }
                    
                   
                }
            }

            int sum = 0;

           
            foreach(KeyValuePair<string,Folder> pair in folders)
            {
 
                foreach(string subfolder in pair.Value.subFolders)
                {
                    pair.Value.fileSize += folders[subfolder].fileSize;
                    
                }

                if(pair.Value.fileSize <= 100000)
                {
                    sum += pair.Value.fileSize;
                }
                
            }
            Console.WriteLine(sum);    
        }
        
        }


        class Folder
        {
            public string name;
            public List<string> subFolders;
            public int fileSize;

            public Folder(string name, List<string> subFolders, int fileSize)
            {
                this.name = name;
                this.subFolders = subFolders;
                this.fileSize = fileSize;
            }
        }
        


    }

