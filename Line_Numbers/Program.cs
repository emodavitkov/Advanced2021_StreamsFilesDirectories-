using System;
using System.IO;
using System.Linq;
using System.Text.RegularExpressions;

namespace Line_Numbers
{
    class Program
    {
        static void Main(string[] args)
        {
            //Write a program that reads a text file and inserts line numbers in front of each of its lines and count all the letters and punctuation marks.
            //The result should be written to another text file.Use the static class File.
            
            string[] lines = File.ReadAllLines("../../../text.txt");
            
            string[] newLines = new string[lines.Length];
            
            int lineCount = 0;
            
            foreach (var line in lines)
            {
                lineCount++;
                int letters = Regex.Matches(line, @"[A-Za-z]").Count;
                int punctuationMarks = Regex.Matches(line, @"[-.,?!'""]").Count;
                newLines[lineCount - 1] = $"Line {lineCount}: " + line + $" ({letters})({punctuationMarks})";
            }

            File.WriteAllLines("../../../output.txt", newLines);

            ////using (StreamReader reader = new StreamReader("../../../text.txt"))
            ////{
            ////    using (StreamWriter writer = new StreamWriter("../../../output.txt"))
            ////    {
            ////        string line = reader.ReadLine();
            ////        int row = 1;
            ////        while (line != null)
            ////        {
            ////            int countLetters = 0;
            ////            int countEmptySpace = 0;
            ////            int countPunctuations = 0;

            ////            for (int i = 0; i < line.Length; i++)
            ////            {
            ////                if (char.IsLetter(line[i]))
            ////                {
            ////                    countLetters++;
            ////                }

            ////                if (line[i]==' ')
            ////                {
            ////                    countEmptySpace++;
            ////                }
            ////            }

            ////            countPunctuations = line.Length - countEmptySpace - countLetters;
            ////            writer.WriteLine($"Line {row}: {line} ({countLetters}) ({countPunctuations})");
            ////            row++;
            ////            line = reader.ReadLine();
            ////        }
            ////    }
            ////}


         }
    }
}

//string[] lines = File.ReadAllLines("../../../../Resources/text.txt");
//string[] newLines = new string[lines.Length];
//int lineCount = 0;
//foreach (var line in lines)
//{
//    lineCount++;
//    int letters = Regex.Matches(line, @"[A-Za-z]").Count;
//    int punctuationMarks = Regex.Matches(line, @"[-.,?!'""]").Count;
//    newLines[lineCount - 1] = $"Line {lineCount}: " + line + $" ({letters})({punctuationMarks})";
//}

//File.WriteAllLines("../../../../Resources/output.txt", newLines);