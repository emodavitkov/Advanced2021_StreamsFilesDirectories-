using System;
using System.IO;

namespace OddLines
{
    class Program
    {
        static void Main(string[] args)
        {

            string directory = Environment.CurrentDirectory;
            Console.WriteLine(directory);
            using (StreamReader reader = new StreamReader("../../../input.txt"))
            //using (StreamReader reader = new StreamReader(@"C:\Users\A474627\Desktop\input.txt"))
            {

                string currentRow = reader.ReadLine();

                int row = 0;

                using (StreamWriter writer = new StreamWriter("../../../output.txt"))
                {
                    while (currentRow != null)
                    {
                        if (row % 2 == 1)
                        {
                            writer.WriteLine(currentRow);
                        }

                        currentRow = reader.ReadLine();
                        row++;
                    }
                }
                
            }
        }
    }
}
