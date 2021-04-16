using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;

namespace DirectoryTraversal
{
    class Program
    {
        static void Main(string[] args)
        {
            string directory = @"C:\Users\A474627\source\repos\StreamsFilesAndDirectories\Directory_Traversal";
            string desktopDirectory = Environment.GetFolderPath(Environment.SpecialFolder.Desktop);
            Dictionary<string, Dictionary<string, double>> fileByExtensions = new Dictionary<string, Dictionary<string, double>>();

            string[] filesInDirectory = Directory.GetFiles(directory);
            foreach (var file in filesInDirectory)
            {
                FileInfo fileInfo = new FileInfo(file);
                if (!fileByExtensions.ContainsKey(fileInfo.Extension.ToLower()))
                {
                    fileByExtensions.Add(fileInfo.Extension.ToLower(), new Dictionary<string, double>());
                }

                fileByExtensions[fileInfo.Extension.ToLower()].Add(fileInfo.Name, fileInfo.Length / 1024.0);
            }
            StringBuilder output = new StringBuilder();
            foreach (var extension in fileByExtensions.OrderByDescending(c => c.Value.Count).ThenBy(n => n.Key))
            {
                output.AppendLine(extension.Key);
                foreach (var file in extension.Value.OrderBy(s => s.Value))
                {
                    output.AppendLine($"--{file.Key} - {file.Value:F2}kb");
                }
            }

            File.WriteAllText(Path.Combine(desktopDirectory, "report.txt"), output.ToString());

        }
    }
}