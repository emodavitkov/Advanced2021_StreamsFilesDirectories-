using System;
using System.IO.Compression;

namespace ZipAndExtract
{
    class Program
    {
        static void Main(string[] args)
        {
            ZipFile.CreateFromDirectory(@"C:\Users\A474627\source\repos\StreamsFilesAndDirectories\Zip_And_Extract\copyMe.png", @"C:\Users\Public");
        }
    }
}