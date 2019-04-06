using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text.RegularExpressions;
using System.Text;

namespace FileGenerator
{
    public class VMFParse
    {
        static void Main(string[] args)
        {
            ParseVMF(args[0]);
        }

        private static string ParseVMF(string mapDirectory)
        { 
            // Get CT and T Faction Integers
            string[] parsedMap = File.ReadAllLines(mapDirectory);
            int counter = 0;
            bool matched = false;
            int ctFaction;
            int tFaction;

            foreach (string s in parsedMap)
            {
                if (s.Contains("s_kvfile"))
                {
                    matched = true;
                    break;
                }
                else
                {
                    counter++;
                }
            }
            if (matched == false) StopProgram("VMF file does not contain an s_kvfile point entity");
            ctFaction = int.Parse(Regex.Match(parsedMap[counter + 1], @"\d+").Value);
            tFaction = int.Parse(Regex.Match(parsedMap[counter + 2], @"\d+").Value);

        }

        private static void StopProgram(string myError)
        {
            Console.WriteLine(myError);
            Console.ReadKey();
            System.Environment.Exit(0);
        }

    }
}
