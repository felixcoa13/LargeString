using System;
using System.Collections.Generic;
using System.IO;

namespace LargeString
{
    class Utils
    {
        public static void Print(char[][] array)
        {
            for(var i=0; i < array.Length; i++)
            {
                for (var j = 0; j < array[i].Length; j++)
                {
                    Console.Write($"{array[i][j]} ");
                }
                Console.WriteLine();
            }
        }

        public static char[][] ReadInputFile(string path)
        {
            List<char[]> result = new List<char[]>();
            var lines = ReadInputFileLines(path);
            foreach(var line in lines)
            {
                var letters = line.Replace(", ", "").Replace(",", "").ToCharArray();
                result.Add(letters);
            }
            return result.ToArray();
        }

        public static string[] ReadInputFileLines(string path)
        {
            List<string> lines = new List<string>();
            string line;
            try
            {
                StreamReader sr = new StreamReader(path);
                line = sr.ReadLine();
                while (line != null)
                {
                    lines.Add(line);
                    line = sr.ReadLine();
                }
                sr.Close();
                return lines.ToArray();
            }
            catch (Exception e)
            {
                Console.WriteLine("Exception: " + e.Message);
            }
            return null;
        }
    }
}
