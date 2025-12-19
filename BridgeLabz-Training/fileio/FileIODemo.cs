using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;   //for file IO

namespace BridgeLabz_Training.fileio
{
    internal class FileIODemo
    {
        static void Main(string[] args)
        {
            //write to a file, creates the file if not exists and overwrites it if present.
            File.WriteAllText("data.txt", "Hello File IO");

            //reads from a file 
            string content = File.ReadAllText("data.txt");
            Console.WriteLine(content);

            //appead to a file 
            File.AppendAllText("data.txt", "\nNew Line Added");

            //create a directory(folder)
            Directory.CreateDirectory("Folder1");

            //check existence of a file 
            if (File.Exists("data.txt"))
            {
                Console.WriteLine("File exists");
            }


            //USING STREAMWRITER AND STREAMREADER -> BETTER PRACTISE THAN FILE IO METHODS -> BETTER MEMORY EFFICIENT AND PERFORMANCE

            //write to a new file 
            using (StreamWriter writer = new StreamWriter("log.txt"))
            {
                writer.WriteLine("First line in log.txt");
                writer.WriteLine("Second line in log.txt");
            }

            //append to existing file, add a true argument for it 
            using (StreamWriter writer  = new StreamWriter("log.txt", true))
            {
                writer.WriteLine("Added a new line");
            }


            //reading 
            using (StreamReader reader = new StreamReader("log.txt"))
            {
                string line;
                while ((line = reader.ReadLine()) != null)
                {
                    Console.WriteLine(line);
                }
            }


            //BETTER TO USE EXEPTION HANDLING WITH FILE IO
            try
            {
                File.ReadAllLines("test1.txt");

            }
            catch(FileNotFoundException ex)
            {
                Console.WriteLine("File not found!");
            }


        }
    }
}
