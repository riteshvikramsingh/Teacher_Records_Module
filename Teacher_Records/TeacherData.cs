using System;
using System;
using System.Collections.Generic;
using System.IO;
using System.Text;

namespace Teacher_Records
{
    class TeacherData
    {
        public static void Teachernfo()
        {
            Console.ForegroundColor = ConsoleColor.Green;
            Console.WriteLine("Teacher Information!!!");
            string path = Directory.GetCurrentDirectory();
            string filename = "TeacherRecords.txt";
            if (!File.Exists(filename))
            {
                Console.WriteLine("File is not present, creating new file");
            }
            else
            {
                Console.WriteLine("File is Present!!!");
            }
            using (StreamWriter writer = File.CreateText(filename))
            {
                writer.WriteLine("ID: T01; Name: Sanjeev; Class:10; Section:A");
                writer.WriteLine("ID: T04; Name: Meetu; Class:09; Section:A");
                writer.WriteLine("ID: T06; Name: Senthil; Class:10; Section:B");
                writer.WriteLine("ID: T02; Name: Chinmay; Class:08; Section:A");
                writer.WriteLine("ID: T03; Name: Vamsi; Class:09; Section:B");
                writer.WriteLine("ID: T05; Name: Viswes; Class:08; Section:B");
            }

            string text = File.ReadAllText(filename);
            Console.ForegroundColor = ConsoleColor.Blue;
            Console.WriteLine(text);
            Console.ForegroundColor = ConsoleColor.Green;
            Console.WriteLine("Teacher Infomation Displayed");

        }
    }
}

