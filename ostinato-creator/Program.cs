using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ostinato_creator
{
    class Program
    {
        public static string[] values = { "Fjerdedel", "Åttedel", "Triol", "Sekstendedel", "pause" };

        public static int[] numValues = { 4, 8, 3, 16, 0 };

        public static Random random = new Random();

        public static List<string> ostenato = new List<string>();

        public static string outputPath = @"..\\..\\..\\ostenato.txt";

        static void Main(string[] args)
        {
            Console.WriteLine("Ostenato creator!");

            if (File.Exists(outputPath))
            {
                File.Delete(outputPath);
            }

            for (int i = 0; i < 10; i++)
            {
                try
                {
                    string str = numValues[random.Next(0, numValues.Length)].ToString();
                    Console.WriteLine(str);
                    ostenato.Add(str);
                }
                catch (Exception e)
                {
                    Console.WriteLine(e.Message);
                    break;
                }
            }

            WriteToOutput();
            Console.ReadKey();
        }

        static void WriteToOutput()
        {
            File.WriteAllText(outputPath, String.Join(", ", ostenato.ToArray()));

        }
    }
}
