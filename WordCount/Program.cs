using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text.RegularExpressions;

namespace WordCount
{
    class Program
    {
        static void Main(string[] args)
        {
            string allText = File.ReadAllText("text.txt").ToLower();
            string[] splited = Regex.Split(allText, @"[^A-Za-z]").Where(s => s.Length != 0).ToArray();
            Dictionary<string, int> wordCounts = new Dictionary<string, int>();
            string[] words = File.ReadAllLines("words.txt");
            int[] count = new int[3];

            foreach (var word in words)
            {
                if (!wordCounts.ContainsKey(word))
                {
                    wordCounts.Add(word, 0);
                }
            }

            foreach (var word in splited)
            {
                if (wordCounts.ContainsKey(word))
                {
                    wordCounts[word]++;
                }
            }

            List<string> output = new List<string>();
            foreach (var pair in wordCounts.OrderByDescending(c => c.Value))
            {
                output.Add($"{pair.Key} - {pair.Value}");
            }
            File.WriteAllLines("../../../actualResult.txt", output);
        }
    }
}