using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;

namespace FileGenerator
{
    class VMFParse
    {
        static void Main(string[] args)
        {
            GetCTNumber(args[0]);
        }

        private static string GetCTNumber(string mapDirectory)
        {
            string[] parsedMap = File.ReadAllLines(mapDirectory);
            foreach (string s in parsedMap)
            {
                if (s.Contains("CTFaction"))
                {
                    break;
                }
                else
                {

                }
            }

        }

    }
}
