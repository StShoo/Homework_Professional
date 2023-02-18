using System;
using System.IO;
using System.IO.Compression;
using System.Text;

namespace Homework_P_3_task_2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            var fileToFind = new FileInfo(@"C:\Users\lumen\Files\Text.txt");
            FileStream destenation = File.Create(@"C:\Users\lumen\Files\archive.zip");

            try
            {
                FileStream stream = fileToFind.Open(FileMode.Open);
                GZipStream compressor = new GZipStream(destenation, CompressionMode.Compress);

                Console.WriteLine($"Full name: {fileToFind.FullName}\n" +
                    $"Time of Creation {fileToFind.CreationTime}");

                Console.WriteLine("Contains:");

                byte[] b = new byte[1024];
                UTF8Encoding temp = new UTF8Encoding(true);
                int readLen;
                while ((readLen = stream.Read(b, 0, b.Length)) > 0)
                {
                    Console.WriteLine(temp.GetString(b, 0, readLen));
                }

                int theByte = stream.ReadByte();
                while(theByte != -1)
                {
                    compressor.WriteByte((byte)theByte);
                    theByte = stream.ReadByte();
                }

                compressor.Close();
                stream.Close();
            } catch(Exception e)
            {
                Console.WriteLine(e.Message);
            }
        }
    }
}