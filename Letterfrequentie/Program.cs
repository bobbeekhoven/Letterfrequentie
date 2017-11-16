using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace Letterfrequentie
{
    class Program
    {
        static void Main()
        {
            // Array to store frequencies
            int[] c = new int[(int)char.MaxValue];

            //Read entire text file
            string s = File.ReadAllText("lorem.txt");

            // Iterate over each character
            foreach (char t in s)
            {
                // Increment table
                c[(int)t]++;
            }
            // Write all letters found (press enter to continue)
            for (int i = 0; i < (int)char.MaxValue; i++)
            {
                if (c[i]> 0 && char.IsLetterOrDigit((char)i))
                {
                    Console.WriteLine("Letter: {0} Frequency: {1}", (char)i, c[i]);
                    Console.WriteLine("Press enter for next value");
                    Console.ReadLine();
                }
            }
        }
    }
}
