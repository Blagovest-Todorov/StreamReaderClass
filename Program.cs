using System;
using System.IO;

namespace StreamsFiles
{
    class Program
    {
        static void Main(string[] args)
        {
            // StreamReader reader = new StreamReader("../../../input.txt");
            StreamReader reader = 
                new StreamReader(@"C:\Users\Bla\source\repos\MultidimensionalArrays\StreamsFiles\input.txt");
            string line = reader.ReadLine(); // StringReader returns string Data.
            Console.WriteLine(line);
            reader.Close();
            //Stream - flow of Data, with class StreamReader we can read data and return a string.
            //Streams  are used to transfer Data,  Qw open stream to read Data and to Write data
            //Streams are means of transfering Data, ordered sequence of bytes.
            // File Streams, NetworkStreams, MemoryStreams, 
            // Streams are opend before using them and close after that.
        }
    }
}
