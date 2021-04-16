using System;
using System.IO;

namespace StreamsFilesAndDirectories
{
    class Program
    {
        static void Main(string[] args)
        {
            //using using and no need of close
            using (StreamReader test = new StreamReader(@"C:\Users\A474627\Desktop\input.txt"))
            {
                string lineTest = test.ReadLine();
                Console.WriteLine(lineTest);
            }


            StreamReader reader = new StreamReader(@"C:\Users\A474627\Desktop\input.txt");

            //StreamReader reader = new StreamReader("../../../input.txt");

            string line = reader.ReadLine();

            Console.WriteLine(line);

            //using close to prevent memory leak
            reader.Close();

            StreamWriter writer = new StreamWriter(@"C:\Users\A474627\Desktop\input.txt", true);

            writer.WriteLine("Files are cool");
            writer.Close();
        }
    }
}
