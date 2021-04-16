using System;
using System.IO;
using System.Linq;
using System.Text.RegularExpressions;

namespace EvenLines
{
    class Program
    {
        static void Main(string[] args)
        {

            //Write a program that reads a text file and prints on the console its even lines. Line numbers start from 0.Use StreamReader.
            //Before you print the result replace { "-", ",", ".", "!", "?"}
            //with "@" and reverse the order of the words.


            using (StreamReader reader = new StreamReader(@"C:\Users\A474627\source\repos\StreamsFilesAndDirectories\EvenLines\text.txt"))
            {
                string line = reader.ReadLine();

                int counter = 0;

                var writer = new StreamWriter("../../../output.txt");
                using(writer)
                {

                    while (line != null)
                    {

                        if (counter++ % 2 != 0)
                        {

                            //easiest approach
                            //line = line.Replace('-', '@');
                            //line = line.Replace(',', '@');
                            //line = line.Replace('.', '@');
                            //line = line.Replace('!', '@');
                            //line = line.Replace('?', '@');

                            //regex approach
                            Regex regex = new Regex(@"[-,.!?]");
                            line = regex.Replace(line, "@");

                            string[] words = line.Split((" "),
                                StringSplitOptions.RemoveEmptyEntries);

                            //just example but not applicable here
                            //string[] words = line.Split ( new string[] {" - ", ", ", ".", "!", " ? "},
                            //    StringSplitOptions.RemoveEmptyEntries);

                            writer.WriteLine(string.Join(" ", words.Reverse()));
                            //Console.WriteLine(string.Join(" ", words.Reverse()));

                        }

                        line = reader.ReadLine();

                    }

                }
                

                

                }
        }
    }
}
