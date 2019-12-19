using FastHashes;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Give me something to hash:");
            string input = Console.ReadLine();
            var bytes = Encoding.Default.GetBytes(input);
            var hash = new MurmurHash32();
            var hashBytes = hash.ComputeHash(bytes);
            Console.WriteLine(Encoding.Default.GetString(hashBytes));
        }
    }
}
